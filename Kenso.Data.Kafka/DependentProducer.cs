using Chr.Avro.Abstract;
using Chr.Avro.Confluent;
using Chr.Avro.Representation;
using Confluent.Kafka;
using Confluent.Kafka.Admin;
using Confluent.SchemaRegistry;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Schema = Confluent.SchemaRegistry.Schema;

namespace Kenso.Data.Kafka
{
    public class DependentProducer<TK, TV>
    {
        private readonly ClientHandle _clientHandle;
        private readonly KafkaOptions _kafkaOptions;
        private readonly ILogger<DependentProducer<TK, TV>> _logger;
        private IProducer<TK, TV>? _producer;
        public DependentProducer(ClientHandle handle, IOptions<KafkaOptions> kafkaOptions, ILogger<DependentProducer<TK, TV>> logger)
        {
            _clientHandle = handle;
            _kafkaOptions = kafkaOptions.Value;
            _logger = logger;
        }

        public async Task BuildProducer()
        {
            using var registryClient = new CachedSchemaRegistryClient(
                    new SchemaRegistryConfig
                    {
                        Url = _kafkaOptions.SchemaRegistries
                    });

            await EnsureTopicExists();
            _producer = await CreateProducer(registryClient);

        }
        private async Task<IProducer<TK, TV>> CreateProducer(ISchemaRegistryClient registryClient)
        {
            _logger.LogInformation("Creating Kafka producer.");
            var schemaBuilder = new SchemaBuilder();
            var schemaWriter = new JsonSchemaWriter();

            var keySchemaId = await registryClient.RegisterSchemaAsync(
                SubjectNameStrategy.Topic.ConstructKeySubjectName(_kafkaOptions.Topic),
                new Schema(schemaWriter.Write(schemaBuilder.BuildSchema<TK>()), SchemaType.Avro));

            var valueSchemaId = await registryClient.RegisterSchemaAsync(
                SubjectNameStrategy.Topic.ConstructValueSubjectName(_kafkaOptions.Topic),
                new Schema(schemaWriter.Write(schemaBuilder.BuildSchema<TV>()), SchemaType.Avro));

            var producerBuilder = new DependentProducerBuilder<TK, TV>(_clientHandle.Handle);

            await producerBuilder.SetAvroKeySerializer(registryClient, keySchemaId);
            await producerBuilder.SetAvroValueSerializer(registryClient, valueSchemaId);

            return producerBuilder.Build();
        }

        public async Task EnsureTopicExists()
        {
            _logger.LogInformation("Checking if topic exists.");
            if (_kafkaOptions.ProducerSettings == null || _kafkaOptions.ProducerSettings["BootstrapServers"] == null)
            {
                throw new ArgumentException("Kafka:ProducerSettings:BootstrapServers setting nor provided!");
            }

            var admin = new AdminClientBuilder(
                    new AdminClientConfig
                    {
                        BootstrapServers = _kafkaOptions.ProducerSettings["BootstrapServers"]
                    })
                .Build();

            var metadata = admin.GetMetadata(_kafkaOptions.Topic, TimeSpan.FromSeconds(15));

            if (metadata.Topics.All(m => m.Topic != _kafkaOptions.Topic))
            {
                _logger.LogInformation(
                    "Creating topic: '{topic}', Number of Partitions: {partitions}, Replication Factor: {ReplicationFactor}.",
                    _kafkaOptions.Topic, _kafkaOptions.NumPartitions, _kafkaOptions.ReplicationFactor);

                await admin.CreateTopicsAsync(
                    new[]
                    {
                        new TopicSpecification
                        {
                            Name = _kafkaOptions.Topic, NumPartitions = _kafkaOptions.NumPartitions, ReplicationFactor = _kafkaOptions.ReplicationFactor
                        },
                    });
            }
            else
            {
                _logger.LogInformation("Topic '{topic}' already exists.", _kafkaOptions.Topic);
            }
        }

        /// <summary>
        ///     Asynchronously produce a message and expose delivery information
        ///     via the returned Task. Use this method of producing if you would
        ///     like to await the result before flow of execution continues.
        /// </summary>
        public Task ProduceAsync(string topic, Message<TK, TV> message)
        {
            if (_producer == null)
            {
                throw new InvalidOperationException(
                    "Producer not initialized. Call 'BuildProducer' before you start producing messages.");
            }

            return _producer.ProduceAsync(topic, message);
        }

        /// <summary>
        ///     Asynchronously produce a message and expose delivery information
        ///     via the provided callback function. Use this method of producing
        ///     if you would like flow of execution to continue immediately, and
        ///     handle delivery information out-of-band.
        /// </summary>
        public void Produce(string topic, Message<TK, TV> message,
            Action<DeliveryReport<TK, TV>> deliveryHandler = null)
        {
            if (_producer == null)
            {
                throw new InvalidOperationException(
                    "Producer not initialized. Call 'BuildProducer' before you start producing messages.");
            }
            
            _producer.Produce(topic, message, deliveryHandler);
        }

        public void Produce(Message<TK, TV> message, Action<DeliveryReport<TK, TV>> deliveryHandler = null)
        {
            if (_producer == null)
            {
                throw new InvalidOperationException(
                    "Producer not initialized. Call 'BuildProducer' before you start producing messages.");
            }

            _producer.Produce(_kafkaOptions.Topic, message, deliveryHandler);
        }

        public void Flush(TimeSpan timeout)
            => _producer?.Flush(timeout);
    }
}
