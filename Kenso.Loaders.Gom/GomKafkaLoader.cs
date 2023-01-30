using Confluent.Kafka;
using Kenso.Data.Kafka;
using Kenso.Domain;
using Kenso.Loaders.Gom.Model;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace Kenso.Loaders.Gom
{
    public class GomKafkaLoader
    {
        private readonly GomXmlParser _gomXmlParser;
        private readonly DependentProducer<string, GomFeatureMessage> _kafkaProducer;
        private readonly IOptions<GomOptions> _gomOptions;
        private readonly ILogger<GomKafkaLoader> _logger;

        public GomKafkaLoader(GomXmlParser gomXmlParser, DependentProducer<string, GomFeatureMessage> kafkaProducer, IOptions<GomOptions> gomOptions, ILogger<GomKafkaLoader> logger)
        {
            _gomXmlParser = gomXmlParser;
            _kafkaProducer = kafkaProducer;
            _gomOptions = gomOptions;
            _logger = logger;
        }

        public void Run()
        {
            var elementsList = _gomXmlParser.GetGomElements(_gomOptions.Value.PathToXmlDir);
            if (!elementsList.Any())
            {
                return;
            }

            foreach (var gomElements in elementsList)
            {
                _logger.LogInformation("Sending features from '{fileName}'", gomElements.FileName);
                var msg = CreateMessage(gomElements);

                foreach (var gomImportMessage in msg)
                {
                    var key = $"{gomImportMessage.FileName}:{gomImportMessage.Feature.Name}";
                    _kafkaProducer.Produce(new Message<string, GomFeatureMessage>
                        {
                            Key = key,
                            Value = gomImportMessage
                        },
                        (deliveryReport) =>
                        {
                            if (deliveryReport.Error.Code != ErrorCode.NoError)
                            {
                                _logger.LogError($"Failed to deliver message: {deliveryReport.Error.Reason}");
                            }
                            else
                            {
                                _logger.LogInformation($"Produced event: key = {key}");
                            }
                        });
                }
            }

            _gomXmlParser.Archive(elementsList.Select(p => p.FileName),
                _gomOptions.Value.PathToXmlDir,
                _gomOptions.Value.PathToArchiveDir);
        }

        public List<GomFeatureMessage> CreateMessage(GomElements elements)
        {
            var msgs = new List<GomFeatureMessage>();

            foreach (var nominalFeature in elements.Nominal)
            {
                var actual = elements.Actual.FirstOrDefault(p => p.GomId == nominalFeature.Actual);
                var msg = new GomFeatureMessage
                {
                    ImportDate = elements.ImportDate,
                    FileName = elements.FileName,
                    AngleUnit = elements.AngleUnit,
                    LengthUnit = elements.LengthUnit,
                    GomVersion = elements.GomVersion,
                    Feature = nominalFeature,
                    Actual = actual,
                    Part = elements.Part,
                    ModelName = elements.Model
                };
                msgs.Add(msg);
            }

            return msgs;
        }
    }
}
