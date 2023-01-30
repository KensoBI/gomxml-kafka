using Kenso.Data.Kafka;
using Kenso.Data.Repository;
using Kenso.Data.Repository.Postgres;
using Kenso.Loaders.Gom;
using Kenso.Loaders.Gom.Model;
using Kenso.Services.Gom.PgSubscriber;

var host = Host.CreateDefaultBuilder(args)
    .ConfigureServices((context, services) =>
    {
        var connectionString = context.Configuration["ConnectionString"] ?? string.Empty;
        if (string.IsNullOrEmpty(connectionString))
        {
            throw new ArgumentException("'ConnectionString' not provided.");
        }

        services.AddOptions<KafkaOptions>().BindConfiguration("Kafka");
        services.AddSingleton<Consumer<string, GomFeatureMessage>>();
        services.AddSingleton<IMessageHandler<string, GomFeatureMessage>, KafkaMessageHandler>();
        services.AddSingleton<IModelRepository, ModelPgRepository>(_ => new ModelPgRepository(connectionString));
        services.AddSingleton<IPartRepository, PartPgRepository>(_ => new PartPgRepository(connectionString));
        services.AddSingleton<IFeatureRepository, FeaturePgRepository>(_ => new FeaturePgRepository(connectionString));
        services.AddSingleton<ICharacteristicRepository, CharacteristicPgRepository>(_ => new CharacteristicPgRepository(connectionString));
        services.AddSingleton<IMeasurementRepository, MeasurementRepository>(_ => new MeasurementRepository(connectionString));
        services.AddSingleton<IRepository, KensoRepository>();
        services.AddHostedService<Worker>();

    })
    .Build();

host.Run();
