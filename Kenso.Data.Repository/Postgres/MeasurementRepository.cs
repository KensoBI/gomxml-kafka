using Kenso.Domain;
using Npgsql;

namespace Kenso.Data.Repository.Postgres
{
    public class MeasurementRepository : IMeasurementRepository
    {
        private readonly string _connectionString;
        public MeasurementRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public async Task<long> Insert(Measurement measurement, long characteristicId, string source)
        {
            const string sql = "WITH new_measurement AS (INSERT INTO measurement " +
                               "(characteristic_id, value, deviation, nominal, time, created_by)" +
                               "VALUES (@characteristicId, @value, @deviation, @nominal, @time, @source) " +
                               "ON CONFLICT (characteristic_id, time) DO NOTHING; ";

            await using var dataSource = NpgsqlDataSource.Create(_connectionString);
            await using var cmd = dataSource.CreateCommand(sql);
            cmd.Parameters.AddWithValue("@characteristicId", characteristicId);
            cmd.Parameters.AddWithValue("@value", measurement.Value);
            cmd.Parameters.AddWithValue("@deviation", measurement.Deviation.HasValue ? measurement.Deviation : DBNull.Value);
            cmd.Parameters.AddWithValue("@nominal", measurement.Nominal.HasValue? measurement.Nominal : DBNull.Value);
            cmd.Parameters.AddWithValue("@time", measurement.DateTime);
            cmd.Parameters.AddWithValue("@source", source);

            await using var reader = await cmd.ExecuteReaderAsync();
            reader.Read();
            var measurementId = reader.GetInt64(0);
            return measurementId;
        }
    }
}
