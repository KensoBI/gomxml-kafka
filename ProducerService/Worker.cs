namespace Kenso.Loaders.Gom.ProducerService
{
    public class Worker : BackgroundService
    {
        private readonly GomKafkaLoader _gomKafkaLoader;
        private readonly ILogger<Worker> _logger;

        public Worker(GomKafkaLoader gomKafkaLoader, ILogger<Worker> logger)
        {
            _gomKafkaLoader = gomKafkaLoader;
            _logger = logger;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {
                _gomKafkaLoader.Run();

                _logger.LogInformation("Worker running at: {time}", DateTimeOffset.Now);
                await Task.Delay(10000, stoppingToken); //todo delay setting
            }
        }
    }
}