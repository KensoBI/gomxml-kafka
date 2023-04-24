using Kenso.Domain;

namespace Kenso.Data.Repository
{
    public interface IMeasurementRepository
    {
        Task Insert(Measurement measurement, long characteristicId, string source);
    }
}
