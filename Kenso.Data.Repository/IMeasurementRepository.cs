using Kenso.Domain;

namespace Kenso.Data.Repository
{
    public interface IMeasurementRepository
    {
        Task<long> Insert(Measurement measurement, long characteristicId, string source);
    }
}
