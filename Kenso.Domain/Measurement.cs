namespace Kenso.Domain
{
    public class Measurement
    {
        public Characteristic? Characteristic { get; set; }
        public decimal Value { get; set; }
        public decimal? Deviation { get; set; }
        public decimal? Nominal { get; set; }
        public DateTime DateTime { get; set; }
        public string? CreatedBy { get; set; }
    }
}
