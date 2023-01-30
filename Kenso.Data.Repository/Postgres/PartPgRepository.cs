using Kenso.Domain;
using Npgsql;
using NpgsqlTypes;
using System.Reflection;

namespace Kenso.Data.Repository.Postgres
{
    public class PartPgRepository : IPartRepository
    {
        private readonly string _connectionString;

        public PartPgRepository(string connectionString)
        {
            _connectionString = connectionString;
        }
        public async Task<long> Upsert(Part part, long modelId, string source)
        {
            const string sql = "WITH new_part AS (INSERT INTO part (number, name, description, model_id, create_timestamp, update_timestamp, updated_by) " +
                               "VALUES (@partNumber, @partName, @description, @modelId, NOW(), NOW(), @source) " +
                               "ON CONFLICT (number) DO UPDATE " +
                               "SET name = @partName, model_id = @modelId, description = @description, update_timestamp = 'NOW()', updated_by = @source  RETURNING id)" +
                               "SELECT id FROM new_part";

            await using var dataSource = NpgsqlDataSource.Create(_connectionString);
            await using var cmd = dataSource.CreateCommand(sql);
            cmd.Parameters.AddWithValue("@partNumber", part.Number);
            cmd.Parameters.AddWithValue("@partName",  string.IsNullOrEmpty(part.Name) ? DBNull.Value : part.Name);
            cmd.Parameters.AddWithValue("@description", string.IsNullOrEmpty(part.Description) ? DBNull.Value : part.Description);
            cmd.Parameters.AddWithValue("@modelId", modelId);
            cmd.Parameters.AddWithValue("@source", source);

            await using var reader = await cmd.ExecuteReaderAsync();
            reader.Read();
            var partId = reader.GetInt64(0);
            return partId;
        }

        //public long Insert(Part part, string source)
        //{
        //    var sql = "WITH new_parts AS (\r\n" +
        //              "    INSERT INTO part (number, name, create_timestamp, update_timestamp, updated_by)\r\n" +
        //              $"    VALUES('{part.Number}','{part.Name}', 'NOW()','NOW()', '{source}') \r\n" +
        //              "    ON CONFLICT(number) DO NOTHING\r\n" +
        //              "    RETURNING id\r\n" +
        //              ") SELECT COALESCE(\r\n" +
        //              "    (SELECT id FROM new_parts),\r\n" +
        //              $"    (SELECT id FROM part WHERE number = '{part.Number}')\r\n" +
        //              ") AS partid;";


        //}
    }
}
