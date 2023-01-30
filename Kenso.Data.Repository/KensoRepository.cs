namespace Kenso.Data.Repository
{
    public class KensoRepository : IRepository
    {
        public KensoRepository(IModelRepository modelRepository, IPartRepository partRepository, IFeatureRepository featureRepository, ICharacteristicRepository characteristicRepository)
        {
            ModelRepository = modelRepository;
            PartRepository = partRepository;
            FeatureRepository = featureRepository;
            CharacteristicRepository = characteristicRepository;
        }

        public IModelRepository ModelRepository { get; }
        public IPartRepository PartRepository { get; }
        public IFeatureRepository FeatureRepository { get; }
        public ICharacteristicRepository CharacteristicRepository { get; }
    }
}
