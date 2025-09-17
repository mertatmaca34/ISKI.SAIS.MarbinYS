using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
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

            foreach (var localDb in GetLocalDbInstances())
            {
                servers.Add($"(localdb)\\{localDb}");
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
                "SELECT DB_NAME();" + Environment.NewLine +
                "SELECT " +
                "    SUM(CAST(FILEPROPERTY(name, 'SpaceUsed') AS BIGINT))*8/1024 AS UsedMb," +
                "    SUM(CAST(size AS BIGINT))*8/1024 AS AllocatedMb " +
                "FROM sys.database_files;",
                connection);

            await using var reader = await command.ExecuteReaderAsync();

            string? databaseName = null;
            long? usedMb = null;
            long? allocatedMb = null;

            if (await reader.ReadAsync() && !reader.IsDBNull(0))
                databaseName = reader.GetString(0);

            if (await reader.NextResultAsync() && await reader.ReadAsync())
            {
                if (!reader.IsDBNull(0))
                    usedMb = reader.GetInt64(0);
                if (!reader.IsDBNull(1))
                    allocatedMb = reader.GetInt64(1);
            }

            return new DatabaseInfo(server, databaseName, usedMb, allocatedMb);
        }
        catch
        {
            return null;
        }
    }

    private static IEnumerable<string> GetLocalDbInstances()
    {
        try
        {
            var psi = new ProcessStartInfo("SqlLocalDB", "i")
            {
                RedirectStandardOutput = true,
                RedirectStandardError = true,
                UseShellExecute = false,
                CreateNoWindow = true
            };

            using var process = Process.Start(psi);
            if (process == null)
                return Array.Empty<string>();

            var output = process.StandardOutput.ReadToEnd();
            process.WaitForExit();

            var lines = output.Split(new[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);
            return lines.Length > 0 ? lines : Array.Empty<string>();
        }
        catch
        {
            return Array.Empty<string>();
        }
    }
}
