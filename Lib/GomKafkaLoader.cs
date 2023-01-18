using Confluent.Kafka;
using Kenso.Loaders.Gom.Model;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace Kenso.Loaders.Gom
{
    public class GomKafkaLoader
    {
        private readonly GomXmlParser _gomXmlParser;
        private readonly KafkaDependentProducer<string, GomFeatureMessage> _kafkaProducer;
        private readonly IOptions<GomOptions> _gomOptions;
        private readonly ILogger<GomKafkaLoader> _logger;

        public GomKafkaLoader(GomXmlParser gomXmlParser, KafkaDependentProducer<string, GomFeatureMessage> kafkaProducer, IOptions<GomOptions> gomOptions, ILogger<GomKafkaLoader> logger)
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
                var msg = new GomFeatureMessage();
                msg.ImportDate = elements.ImportDate;
                msg.FileName = elements.FileName;
                msg.AngleUnit = elements.AngleUnit;
                msg.LengthUnit = elements.LengthUnit;
                msg.GomVersion = elements.GomVersion;
                msg.Feature = nominalFeature;
                //todo part

                msgs.Add(msg);
            }

            return msgs;
        }
    }
}
