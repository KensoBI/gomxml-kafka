using Chr.Avro.Confluent;
using Confluent.Kafka;
using Confluent.SchemaRegistry;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace Kenso.Data.Kafka
{
    public class Consumer<TK, TV> : IDisposable
    {
        private readonly ILogger<Consumer<TK, TV>> _logger;
        private readonly IMessageHandler<TK, TV> _messageHandler;
        private readonly string _schemaRegistries;
        private readonly string _topic;
        private readonly string _bootstrapServers;
        private readonly string _groupId;
        private IConsumer<TK, TV>? _consumer;

        public Consumer(ILogger<Consumer<TK, TV>> logger, IOptions<KafkaOptions> kafkaOptions, IMessageHandler<TK, TV> messageHandler)
        {
            _logger = logger;
            _messageHandler = messageHandler;

            if (string.IsNullOrEmpty(kafkaOptions.Value.SchemaRegistries))
            {
                throw new ArgumentException("SchemaRegistries not provided.");
            }

            if (string.IsNullOrEmpty(kafkaOptions.Value.Topic))
            {
                throw new ArgumentException("Topic not provided.");
            }

            if (string.IsNullOrEmpty(kafkaOptions.Value.BootstrapServers))
            {
                throw new ArgumentException("Kafka:ProducerSettings:BootstrapServers setting nor provided!");
            }

            _schemaRegistries = kafkaOptions.Value.SchemaRegistries;
            _topic = kafkaOptions.Value.Topic;
            _bootstrapServers = kafkaOptions.Value.BootstrapServers;
            _groupId = kafkaOptions.Value.GroupId;
        }

        public async Task StartConsumerLoop(CancellationToken cancellationToken)
        {
            _logger.LogInformation("Starting consumer loop.");
            _consumer ??= Init();

            while (!cancellationToken.IsCancellationRequested)
            {
                try
                {
                    var cr = _consumer.Consume(cancellationToken);
                    await _messageHandler.Handle(cr.Message);

                    _logger.LogInformation($"{cr.Message.Key}: {cr.Message.Value}");
                }
                catch (OperationCanceledException)
                {
                    break;
                }
                catch (ConsumeException e)
                {
                    // Consumer errors should generally be ignored (or logged) unless fatal.
                    _logger.LogError($"Consume error: {e.Error.Reason}. Message {e.Message}" );

                    if (e.Error.IsFatal)
                    {
                        // https://github.com/edenhill/librdkafka/blob/master/INTRODUCTION.md#fatal-consumer-errors
                        break;
                    }
                }
                catch (Exception e)
                {
                    _logger.LogError($"Unexpected error: {e}");
                    break;
                }
            }
        }

        public IConsumer<TK, TV> Init()
        {
            _logger.LogInformation($"Initializing consumer for topic:{_topic}, groupId: {_groupId}, bootstrapServers: {_bootstrapServers}");

            var registryClient = new CachedSchemaRegistryClient(
                new SchemaRegistryConfig
                {
                    Url = _schemaRegistries
                });
            var consumer = CreateConsumer(registryClient);
            consumer.Subscribe(_topic);
            return consumer;
        }

        private IConsumer<TK, TV> CreateConsumer(ISchemaRegistryClient registryClient)
        {
            return new ConsumerBuilder<TK, TV>(
                    new ConsumerConfig
                    {
                        BootstrapServers = _bootstrapServers,
                        EnableAutoCommit = false,
                        GroupId = _groupId,
                    })
                .SetAvroKeyDeserializer(registryClient)
                .SetAvroValueDeserializer(registryClient)
                .Build();
        }

        public void Dispose()
        {
            if (_consumer == null) return;
            _consumer.Close(); // Commit offsets and leave the group cleanly.
            _consumer.Dispose();
        }
    }
}
