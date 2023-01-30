using Kenso.Domain;
using Npgsql;

namespace Kenso.Data.Repository.Postgres
{
    public class FeaturePgRepository : IFeatureRepository
    {
        private readonly string _connectionString;

        public FeaturePgRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public async Task<long> Upsert(Feature feature, long partId, string source)
        {
            const string sql = "WITH new_feature AS (INSERT INTO feature " +
                               "(part_id, name, description, type, reference, comment, external_id, create_timestamp, update_timestamp, updated_by) " +
                               "VALUES (@partId, @featureName, @description, @featureType, @reference, @comment, @externalId, NOW(), NOW(), @source) " +
                               "ON CONFLICT (part_id, name) DO UPDATE " +
                               "SET " +
                                   "description = @description, " +
                                   "type = @featureType, " +
                                   "reference = @reference," +
                                   "comment = @comment, " +
                                   "external_id = @externalId, " +
                                   "update_timestamp = 'NOW()', " +
                                   "updated_by = @source " +
                                   "RETURNING id)" +
                               "SELECT COALESCE(\r\n" +
                               "    (SELECT id FROM new_feature),\r\n" +
                               "    (SELECT id FROM feature WHERE part_id = @partId AND name = @featureName))" +
                               " AS featureId;";

            await using var dataSource = NpgsqlDataSource.Create(_connectionString);
            await using var cmd = dataSource.CreateCommand(sql);
            cmd.Parameters.AddWithValue("@partId", partId);
            cmd.Parameters.AddWithValue("@featureName", feature.Name);
            cmd.Parameters.AddWithValue("@description", string.IsNullOrEmpty(feature.Description) ? DBNull.Value : feature.Description);
            cmd.Parameters.AddWithValue("@featureType", (int)feature.Type);
            cmd.Parameters.AddWithValue("@reference", feature.Reference.HasValue ? feature.Reference : DBNull.Value);
            cmd.Parameters.AddWithValue("@comment", string.IsNullOrEmpty(feature.Comment) ? DBNull.Value : feature.Comment);
            cmd.Parameters.AddWithValue("@externalId", string.IsNullOrEmpty(feature.ExternalId) ? DBNull.Value : feature.ExternalId);
            cmd.Parameters.AddWithValue("@source", source);

            await using var reader = await cmd.ExecuteReaderAsync();
            reader.Read();
            var featureId = reader.GetInt64(0);
            return featureId;
        }
    }
}
