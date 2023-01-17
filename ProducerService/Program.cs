using Kenso.Loaders.Gom;
using Kenso.Loaders.Gom.Model;
using Kenso.Loaders.Gom.ProducerService;

IHost host = Host.CreateDefaultBuilder(args)
    .ConfigureServices((context, services) =>
    {
        services.AddOptions<GomOptions>().BindConfiguration("Gom");
        services.AddOptions<KafkaOptions>().BindConfiguration("Kafka");
        services.AddSingleton<GomXmlParser>();
        services.AddSingleton<KafkaClientHandle>();
        services.AddSingleton<KafkaDependentProducer<string, GomFeatureMessage>>();
        services.AddSingleton<GomKafkaLoader>();
        services.AddHostedService<Worker>();
    })
    .Build();

var producer = host.Services.GetRequiredService<KafkaDependentProducer<string, GomFeatureMessage>>();
await producer.BuildProducer();

host.Run();
