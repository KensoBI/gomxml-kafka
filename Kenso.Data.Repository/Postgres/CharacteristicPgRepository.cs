using Kenso.Domain;
using Npgsql;

namespace Kenso.Data.Repository.Postgres
{
    public class CharacteristicPgRepository : ICharacteristicRepository
    {
        private readonly string _connectionString;
        public CharacteristicPgRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public async Task<long> Upsert(Characteristic characteristic, long featureId, string source)
        {
            const string sql = "WITH new_characteristic AS (INSERT INTO characteristic " +
                               "(feature_id, name, description, nominal, usl, lsl, usl_warn, lsl_warn, unit, external_id, create_timestamp, update_timestamp, updated_by) " +
                               "VALUES (@featureId, @name, @description, @nominal, @usl, @lsl, @uslWarn, @lslWarn, @unit, @externalId, NOW(), NOW(), @source) " +
                               "ON CONFLICT (part_id, name) DO UPDATE " +
                               "SET " +
                                   "feature_id = @featureId," +
                                   "name = @name, " +
                                   "description = @description," +
                                   "nominal = @nominal, " +
                                   "usl = @usl, " +
                                   "lsl = @lsl, " +
                                   "usl_warn = @uslWarn," +
                                   "lsl_warn = @lslWarn," +
                                   "unit = @unit," +
                                   "external_id = @externalId," +
                                   "update_timestamp = 'NOW()'," +
                                   "updated_by = @source " +
                               "RETURNING id)" +
                               "SELECT COALESCE(\r\n" +
                               "    (SELECT id FROM new_characteristic),\r\n" +
                               "    (SELECT id FROM characteristic WHERE part_id = @partId AND name = @featureName) \r\n)" +
                               " AS featureId;";

            await using var dataSource = NpgsqlDataSource.Create(_connectionString);
            await using var cmd = dataSource.CreateCommand(sql);
            cmd.Parameters.AddWithValue("@featureId", featureId);
            cmd.Parameters.AddWithValue("@name", string.IsNullOrEmpty(characteristic.Name) ? DBNull.Value : characteristic.Name);
            cmd.Parameters.AddWithValue("@description", string.IsNullOrEmpty(characteristic.Description) ? DBNull.Value : characteristic.Description);
            cmd.Parameters.AddWithValue("@nominal", characteristic.Nominal);
            cmd.Parameters.AddWithValue("@usl", characteristic.Usl.HasValue ? characteristic.Usl : DBNull.Value);
            cmd.Parameters.AddWithValue("@lsl", characteristic.Lsl.HasValue ? characteristic.Lsl : DBNull.Value);
            cmd.Parameters.AddWithValue("@uslWarn", characteristic.UslWarn.HasValue ? characteristic.UslWarn : DBNull.Value);
            cmd.Parameters.AddWithValue("@lslWarn", characteristic.LslWarn.HasValue ? characteristic.LslWarn : DBNull.Value);
            cmd.Parameters.AddWithValue("@unit", string.IsNullOrEmpty(characteristic.Unit) ? DBNull.Value: characteristic.Unit);
            cmd.Parameters.AddWithValue("@externalId", string.IsNullOrEmpty(characteristic.ExternalId) ? DBNull.Value : characteristic.ExternalId);
            cmd.Parameters.AddWithValue("@source", source);

            await using var reader = await cmd.ExecuteReaderAsync();
            reader.Read();
            var characteristicId = reader.GetInt64(0);
            return characteristicId;
        }
    }
}
