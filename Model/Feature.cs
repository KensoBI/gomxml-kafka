namespace Kenso.Loaders.Gom.Model
{
    public enum FeatureType
    {
        Point,
        Line,
        Plane,
        Circle,
        Ellipse,
        SlottedHole,
        RectangularHole,
        Sphere,
        Cylinder,
        Cone,
        PolygonHole,
        Dimension
    }
    public class Feature
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public uint GomId { get; set; }
        public uint? Actual { get; set; }
        public List<Characteristic> Characteristics  { get; set; } = new();
        public string? Comment { get; set; }
    }
}