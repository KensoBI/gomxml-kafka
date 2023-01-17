namespace Kenso.Loaders.Gom.Model
{
    public class GomElements
    {
        public decimal GomVersion { get; set; } = 0;

        public string LengthUnit { get; set; } = string.Empty;

        public string AngleUnit { get; set; } = string.Empty;

        public List<Feature> Nominal { get; set; } = new List<Feature>();
        public List<Feature> Actual { get; set; } = new List<Feature>();

        public Part Part { get; set; }
        public required DateTime ImportDate { get; set; }
        public required string FileName { get; set; }
    }
}
