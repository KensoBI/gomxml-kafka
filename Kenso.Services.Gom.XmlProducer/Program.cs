using Kenso.Data.Kafka;
using Kenso.Loaders.Gom;
using Kenso.Loaders.Gom.Model;
using Kenso.Services.Gom.XmlProducer;

IHost host = Host.CreateDefaultBuilder(args)
    .ConfigureServices((context, services) =>
    {
        services.AddOptions<GomOptions>().BindConfiguration("Gom");
        services.AddOptions<KafkaOptions>().BindConfiguration("Kafka");
        services.AddSingleton<GomXmlParser>();
        services.AddSingleton<ClientHandle>();
        services.AddSingleton<DependentProducer<string, GomFeatureMessage>>();
        services.AddSingleton<GomKafkaLoader>();
        services.AddHostedService<Worker>();
    })
    .Build();

var producer = host.Services.GetRequiredService<DependentProducer<string, GomFeatureMessage>>();
await producer.BuildProducer();

host.Run();
