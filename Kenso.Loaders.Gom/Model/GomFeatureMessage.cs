namespace Kenso.Loaders.Gom.Model
{
    public class GomFeatureMessage
    {
        public decimal GomVersion { get; set; }

        public string LengthUnit { get; set; }

        public string AngleUnit { get; set; }

        public GomFeature Feature { get; set; }
        public GomFeature? Actual { get; set; }
        public GomPart? Part { get; set; }

        public string? ModelName { get; set; }

        public DateTime ImportDate { get; set; }
        public string? FileName { get; set; }
    }
}
