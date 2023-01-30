using Kenso.Domain;

namespace Kenso.Data.Repository
{
    public interface IFeatureRepository
    {
        Task<long> Upsert(Feature feature, long partId, string source);
    }
}
