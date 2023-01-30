namespace Kenso.Domain
{
    public class Feature
    {
        public Feature(string name)
        {
            Name = name;
        }

        public long Id { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }
        public FeatureType Type { get; set; }
        public long? Reference { get; set; }
        public string? ExternalId { get; set; }
        public Part? Part { get; set; }
        public List<Characteristic> Characteristics { get; set; } = new();
        public string? Comment { get; set; }
    }
}
