namespace Kenso.Data.Repository
{
    public interface IModelRepository
    {
        Task<long> Insert(Domain.Model model, string source);
    }
}
