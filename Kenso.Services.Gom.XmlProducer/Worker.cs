using Kenso.Loaders.Gom;

namespace Kenso.Services.Gom.XmlProducer
{
    public class Worker : BackgroundService
    {
        private readonly GomKafkaLoader _gomKafkaLoader;
        private readonly ILogger<Worker> _logger;
        private readonly object _processLock = new();
        private readonly int _refreshRate = 10000;

        public Worker(GomKafkaLoader gomKafkaLoader, IConfiguration configuration, ILogger<Worker> logger)
        {
            _gomKafkaLoader = gomKafkaLoader;
            _logger = logger;

            var conf = configuration["RefreshRateSeconds"];
            if (conf != null && int.TryParse(conf, out var rateResult))
            {
                _refreshRate = rateResult * 1000;
            }
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {
                lock (_processLock)
                {
                    _gomKafkaLoader.Run();
                }

                _logger.LogInformation("Worker running at: {time}", DateTimeOffset.Now);
                await Task.Delay(_refreshRate, stoppingToken);
            }
        }
    }
}