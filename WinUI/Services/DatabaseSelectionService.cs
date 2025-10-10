using System.IO;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Threading.Tasks;
using Serilog;
using WinUI.Constants;
using WinUI.Models;

namespace WinUI.Services;

public class DatabaseSelectionService : IDatabaseSelectionService
{
    private readonly string _filePath;
    private readonly string _apiSettingsPath;

    public DatabaseSettings? Settings { get; private set; }

    public DatabaseSelectionService()
    {
        _filePath = Path.Combine(AppContext.BaseDirectory, "database.config");
        if (File.Exists(_filePath))
        {
            try
            {
                var json = File.ReadAllText(_filePath);
                Settings = JsonSerializer.Deserialize<DatabaseSettings>(json);
            }
            catch
            {
                // ignore parse errors
            }
        }

        _apiSettingsPath = Path.GetFullPath(Path.Combine(AppContext.BaseDirectory,
            "..", "..", "..", "..", "Api", "appsettings.json"));
    }

    public async Task SaveDatabaseSettingsAsync(DatabaseSettings settings)
    {
        Settings = settings;
        var json = JsonSerializer.Serialize(settings);
        await File.WriteAllTextAsync(_filePath, json);

        try
        {
            if (File.Exists(_apiSettingsPath))
            {
                var apiJson = await File.ReadAllTextAsync(_apiSettingsPath);
                JsonNode root = JsonNode.Parse(apiJson) ?? new JsonObject();

                if (root["ConnectionStrings"] is not JsonObject connStrings)
                {
                    connStrings = new JsonObject();
                    root["ConnectionStrings"] = connStrings;
                }

                string connectionString = BuildConnectionString(settings);
                connStrings["Default"] = connectionString;

                JsonObject serilog = root["Serilog"] as JsonObject ?? new JsonObject();
                root["Serilog"] = serilog;

                JsonObject minLevel = serilog["MinimumLevel"] as JsonObject ?? new JsonObject();
                serilog["MinimumLevel"] = minLevel;
                minLevel["Default"] = settings.LogLevel;

                serilog.Remove("WriteTo");

                await File.WriteAllTextAsync(_apiSettingsPath,
                    root.ToJsonString(new JsonSerializerOptions { WriteIndented = true }));
            }
            Log.Information(LogMessages.DatabaseSelectionService.SettingsSaved, settings.Server);
        }
        catch (Exception ex)
        {
            Log.Error(ex, LogMessages.DatabaseSelectionService.ApiConfigurationUpdateFailed);
        }
    }

    private static string BuildConnectionString(DatabaseSettings settings)
    {
        if (settings.Authentication == "SQL Server Authentication")
        {
            return $"Server={settings.Server};Database=IBKSContext;User Id={settings.Username};Password={settings.Password};TrustServerCertificate=True;";
        }
        return $"Server={settings.Server};Database=IBKSContext;Integrated Security=True;TrustServerCertificate=True;";
    }
}
