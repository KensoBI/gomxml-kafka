namespace Kenso.Data.Kafka
{
    public class KafkaOptions
    {
        public required string Topic { get; set; }
        public required string SchemaRegistries { get; set; }
        public int NumPartitions { get; set; } = 2;
        public short ReplicationFactor { get; set; } = 1;
        public IDictionary<string, string>? ProducerSettings { get; set; }
        public string BootstrapServers { get; set; }
        public string GroupId { get; set; }
    }
}
