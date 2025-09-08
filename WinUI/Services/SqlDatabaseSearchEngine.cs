using System.Collections.Generic;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
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
            DataTable table = SqlDataSourceEnumerator.Instance.GetDataSources();
            foreach (DataRow row in table.Rows)
            {
                string server = row["ServerName"].ToString()!;
                string instance = row["InstanceName"].ToString();
                string full = string.IsNullOrEmpty(instance) ? server : $"{server}\\{instance}";
                servers.Add(full);
            }
            return (IEnumerable<string>)servers;
        });
    }

    public async Task<DatabaseInfo?> GetDatabaseInfoAsync(string server)
    {
        try
        {
            using SqlConnection connection = new($"Server={server};Integrated Security=true;");
            await connection.OpenAsync();

            using SqlCommand command = new("SELECT DB_NAME(); SELECT SUM(size)*8/1024 FROM sys.database_files", connection);
            using SqlDataReader reader = await command.ExecuteReaderAsync();

            string? databaseName = null;
            int? size = null;

            if (await reader.ReadAsync())
            {
                databaseName = reader.GetString(0);
            }

            if (await reader.NextResultAsync() && await reader.ReadAsync())
            {
                size = reader.GetInt32(0);
            }

            return new DatabaseInfo(server, databaseName, size);
        }
        catch
        {
            return null;
        }
    }
}
