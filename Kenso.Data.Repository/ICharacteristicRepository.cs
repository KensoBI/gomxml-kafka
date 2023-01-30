using Kenso.Domain;

namespace Kenso.Data.Repository
{
    public interface ICharacteristicRepository
    {
        Task<long> Upsert(Characteristic characteristic, long featureId, string source);
    }
}
