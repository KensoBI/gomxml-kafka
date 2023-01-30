namespace Kenso.Domain
{
    public class Characteristic
    {
        public long Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public decimal Nominal { get; set; }
        public decimal? Usl { get; set; }
        public decimal? Lsl { get; set; }
        public decimal? UslWarn { get; set; }
        public decimal? LslWarn { get; set; }
        public string? Unit { get; set; }
        public string? ExternalId { get; set; }
        public Feature? Feature { get; set; }
        public List<Measurement> Measurements { get; set; } = new();
    }
}
