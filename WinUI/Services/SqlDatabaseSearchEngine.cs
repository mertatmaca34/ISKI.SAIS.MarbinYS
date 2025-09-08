using Microsoft.Data.SqlClient;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;
using WinUI.Models;

namespace WinUI.Services;

public class SqlDatabaseSearchEngine : IDatabaseSearchEngine
{
    public async Task<IEnumerable<string>> SearchServersAsync()
    {
        return await Task.Run(() =>
        {
            var servers = new List<string>();

            // Microsoft.Data.Sql: SqlDataSourceEnumerator
            DataTable table = Microsoft.Data.Sql.SqlDataSourceEnumerator.Instance.GetDataSources();

            foreach (DataRow row in table.Rows)
            {
                var server = row["ServerName"]?.ToString();
                var instance = row.IsNull("InstanceName") ? null : row["InstanceName"]?.ToString();

                if (string.IsNullOrWhiteSpace(server))
                    continue;

                string full = string.IsNullOrEmpty(instance) ? server! : $"{server}\\{instance}";
                servers.Add(full);
            }

            return (IEnumerable<string>)servers;
        });
    }

    public async Task<DatabaseInfo?> GetDatabaseInfoAsync(string server)
    {
        try
        {
            await using var connection = new SqlConnection(
                $"Server={server};Integrated Security=True;TrustServerCertificate=True;");

            await connection.OpenAsync();

            await using var command = new SqlCommand(
                "SELECT DB_NAME(); SELECT SUM(size)*8/1024 FROM sys.database_files;", connection);

            await using var reader = await command.ExecuteReaderAsync();

            string? databaseName = null;
            int? sizeMb = null;

            if (await reader.ReadAsync() && !reader.IsDBNull(0))
                databaseName = reader.GetString(0);

            if (await reader.NextResultAsync() && await reader.ReadAsync() && !reader.IsDBNull(0))
                sizeMb = reader.GetInt32(0); // toplam boyut (MB)

            return new DatabaseInfo(server, databaseName, sizeMb);
        }
        catch
        {
            return null;
        }
    }
}
