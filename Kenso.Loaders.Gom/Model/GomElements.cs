namespace Kenso.Loaders.Gom.Model
{
    public class GomElements
    {
        public decimal GomVersion { get; set; } = 0;

        public string LengthUnit { get; set; } = string.Empty;

        public string AngleUnit { get; set; } = string.Empty;

        public List<GomFeature> Nominal { get; set; } = new List<GomFeature>();
        public List<GomFeature> Actual { get; set; } = new List<GomFeature>();

        public GomPart Part { get; set; }
        public required DateTime ImportDate { get; set; }
        public required string FileName { get; set; }
        public string? Model { get; set; }
    }
}
