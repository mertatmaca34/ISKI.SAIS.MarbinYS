using System.IO;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Threading.Tasks;

namespace WinUI.Services;

public class DatabaseSelectionService : IDatabaseSelectionService
{
    private readonly string _filePath;
    private readonly string _apiSettingsPath;

    public DatabaseSelectionService()
    {
        _filePath = Path.Combine(AppContext.BaseDirectory, "database.config");
        if (File.Exists(_filePath))
        {
            SelectedServer = File.ReadAllText(_filePath).Trim();
        }

        _apiSettingsPath = Path.GetFullPath(Path.Combine(AppContext.BaseDirectory,
            "..", "..", "..", "..", "Api", "appsettings.json"));
    }

    public string? SelectedServer { get; private set; }

    public async Task SaveSelectedServerAsync(string server)
    {
        SelectedServer = server;
        await File.WriteAllTextAsync(_filePath, server);

        try
        {
            if (File.Exists(_apiSettingsPath))
            {
                var json = await File.ReadAllTextAsync(_apiSettingsPath);
                JsonNode? root = JsonNode.Parse(json);
                if (root?["ConnectionStrings"] is JsonObject connStrings)
                {
                    connStrings["Default"] =
                        $"Server={server};Database=IBKSContext;User Id=sa;Password=atmaca123;TrustServerCertificate=True;";
                    await File.WriteAllTextAsync(_apiSettingsPath,
                        root.ToJsonString(new JsonSerializerOptions { WriteIndented = true }));
                }
            }
        }
        catch
        {
            // ignore errors updating API configuration
        }
    }
}
