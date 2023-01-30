namespace Kenso.Loaders.Gom.Model
{
    public class GomCharacteristic
    {
        public string Name { get; set; }
        public decimal Nominal { get; set; }
        public decimal? Usl { get; set; }
        public decimal? Lsl { get; set; }

        public decimal? UslWarn { get; set; }
        public decimal? LslWarn { get; set; }
        public string? Unit { get; set; }

        public List<GomMeasurement> Measurements { get; set; } = new();
    }
}
