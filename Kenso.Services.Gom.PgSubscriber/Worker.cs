using Kenso.Data.Kafka;
using Kenso.Loaders.Gom.Model;

namespace Kenso.Services.Gom.PgSubscriber
{
    public class Worker : BackgroundService
    {
        private readonly Consumer<string, GomFeatureMessage> _gomPgConsumer;

        public Worker(Consumer<string, GomFeatureMessage> gomPgConsumer)
        {
            _gomPgConsumer = gomPgConsumer;
        }

        protected override Task ExecuteAsync(CancellationToken stoppingToken)
        {
            return _gomPgConsumer.StartConsumerLoop(stoppingToken);
        }
    }
}