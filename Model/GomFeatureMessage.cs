namespace Kenso.Loaders.Gom.Model
{
    public class GomFeatureMessage
    {
        public decimal GomVersion { get; set; }

        public string LengthUnit { get; set; }

        public string AngleUnit { get; set; }

        public Feature Feature { get; set; }

        public Part? Part { get; set; }
        public DateTime ImportDate { get; set; }
        public string? FileName { get; set; }
    }

}
