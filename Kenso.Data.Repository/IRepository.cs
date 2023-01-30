namespace Kenso.Data.Repository
{
    public interface IRepository
    {
        public IModelRepository ModelRepository { get; }
        public IPartRepository PartRepository { get; }
        public IFeatureRepository FeatureRepository { get; }
    }
}
