using Kenso.Domain;

namespace Kenso.Loaders.Gom.Model
{
    public class GomFeature
    {
        public string Name { get; set; }
        public FeatureType Type { get; set; }
        public uint GomId { get; set; }
        public uint? Actual { get; set; }
        public List<GomCharacteristic> Characteristics  { get; set; } = new();
        public string? Comment { get; set; }
    }
}