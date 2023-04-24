using Confluent.Kafka;
using Kenso.Data.Kafka;
using Kenso.Data.Repository;
using Kenso.Domain;
using Kenso.Loaders.Gom.Model;
using Microsoft.Extensions.Logging;
using System.Reflection.PortableExecutable;

namespace Kenso.Loaders.Gom
{
    public class KafkaMessageHandler : IMessageHandler<string, GomFeatureMessage>
    {
        private readonly ILogger<KafkaMessageHandler> _logger;
        private readonly IRepository _repository;

        public KafkaMessageHandler(ILogger<KafkaMessageHandler> logger, IRepository repository)
        {
            _logger = logger;
            _repository = repository;
        }

        public async Task Handle(Message<string, GomFeatureMessage> message)
        {
            if (message.Value == null)
            {
                _logger.LogWarning("Message does not have a Value. Skipping message.");
                return;
            }

            if (message.Value.Part == null)
            {
                _logger.LogWarning("No Part information provided. Skipping message.");
                return;
            }

            long modelId = 0;
            var source = message.Value.FileName ?? message.Key;
            if (!string.IsNullOrEmpty(message.Value.ModelName))
            {
                var modelToInsert = new Domain.Model
                {
                    Name = message.Value.ModelName
                };
                modelId = await _repository.ModelRepository.Insert(modelToInsert, source);
            }

            var partId = await SavePart(message.Value.Part, modelId, source);

            long? actualFeatureId = null;
            if (message.Value.Actual != null)
            {
                actualFeatureId = await SaveFeature(message.Value.Feature, partId, source);
            }

            var featureId = await SaveFeature(message.Value.Feature, partId, source, actualFeatureId);
            foreach (var gomCharacteristic in message.Value.Feature.Characteristics)
            {
                var characteristicId =  await SaveCharacteristic(gomCharacteristic, featureId, source);
                foreach (var gomMeasurement in gomCharacteristic.Measurements)
                {
                    await SaveMeasurement(gomMeasurement, characteristicId, message.Value.ImportDate, source);
                }
            }
        }

        public async Task<long> SavePart(GomPart part, long modelId, string source)
        {
            if (string.IsNullOrEmpty(part.Number))
            {
                _logger.LogWarning("Unable to save Part. Part number not provided.");
                return 0;
            }

            var partToSave = MapPart(part);
            return await _repository.PartRepository.Upsert(partToSave, modelId, source);
        }

        public Part MapPart(GomPart part)
        {
            return new Part(part.Number)
            {
                Name = part.Name,
                Number = part.Number
            };
        }

        public async Task<long> SaveFeature(GomFeature feature, long partId, string source, long? reference = null)
        {
            if (string.IsNullOrEmpty(feature.Name))
            {
                _logger.LogWarning("Unable to save Feature. Feature name not provided.");
                return 0;
            }

            var featureToInsert = MapFeature(feature);
            if (reference != null)
            {
                featureToInsert.Reference = reference;
            }

            return await _repository.FeatureRepository.Upsert(featureToInsert, partId, source);
        }

        private static Feature MapFeature(GomFeature feature)
        {
            return new Feature(feature.Name)
            {
                Comment = feature.Comment,
                Type = feature.Type,
                ExternalId = feature.GomId.ToString()
            };
        }

        public async Task<long> SaveCharacteristic(GomCharacteristic characteristic, long featureId, string source)
        {
            if (string.IsNullOrEmpty(characteristic.Name))
            {
                _logger.LogWarning("Unable to save Characteristic. Characteristic name not provided.");
                return 0;
            }

            var characteristicToInsert = MapCharacteristic(characteristic);
            return await _repository.CharacteristicRepository.Upsert(characteristicToInsert, featureId, source);
        }

        private static Characteristic MapCharacteristic(GomCharacteristic characteristic)
        {
            return new Characteristic
            {
                Name = characteristic.Name,
                Nominal = characteristic.Nominal,
                Lsl = characteristic.Lsl,
                Usl = characteristic.Usl,
                LslWarn = characteristic.LslWarn,
                UslWarn = characteristic.UslWarn,
                Unit = characteristic.Unit
            };
        }

        public async Task SaveMeasurement(GomMeasurement measurement, long characteristicId, DateTime measurementDateTime, string source)
        {
            if (!measurement.Value.HasValue)
            {
                _logger.LogWarning("Unable to save Measurement. Measurement value not set.");
                return;
            }
            var measurementToInsert = MapMeasurement(measurement, measurementDateTime);
            await _repository.MeasurementRepository.Insert(measurementToInsert, characteristicId, source);
        }

        private static Measurement MapMeasurement(GomMeasurement measurement, DateTime measurementDateTime)
        {
            return new Measurement
            {
                Value = measurement.Value ?? 0,
                Nominal = measurement.Nominal,
                Deviation = measurement.Deviation,
                DateTime = measurementDateTime
            };
        }
    }
}
