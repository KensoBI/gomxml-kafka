﻿using Confluent.Kafka;
using Microsoft.Extensions.Configuration;

namespace Kenso.Loaders.Gom
{
    /// <summary>
    ///     Wraps a Confluent.Kafka.IProducer instance, and allows for basic
    ///     configuration of this via IConfiguration.
    ///    
    ///     KafkaClientHandle does not provide any way for messages to be produced
    ///     directly. Instead, it is a dependency of KafkaDependentProducer. You
    ///     can create more than one instance of KafkaDependentProducer (with
    ///     possibly differing K and V generic types) that leverages the same
    ///     underlying producer instance exposed by the Handle property of this
    ///     class. This is more efficient than creating separate
    ///     Confluent.Kafka.IProducer instances for each Message type you wish to
    ///     produce.
    /// </summary>
    public class KafkaClientHandle : IDisposable
    {
        IProducer<byte[], byte[]> _kafkaProducer;

        public KafkaClientHandle(IConfiguration configuration)
        {
            var conf = new ProducerConfig();

            configuration.GetSection("Kafka:ProducerSettings").Bind(conf);

            _kafkaProducer = new ProducerBuilder<byte[], byte[]>(conf).Build();
        }

        public Handle Handle => _kafkaProducer.Handle;

        public void Dispose()
        {
            // Block until all outstanding produce requests have completed (with or without error).
            _kafkaProducer.Flush();
            _kafkaProducer.Dispose();
            GC.SuppressFinalize(this);
        }
    }
}