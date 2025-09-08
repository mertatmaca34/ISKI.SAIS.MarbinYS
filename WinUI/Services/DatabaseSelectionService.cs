using System.IO;
using System.Threading.Tasks;

namespace WinUI.Services;

public class DatabaseSelectionService : IDatabaseSelectionService
{
    private readonly string _filePath;

    public DatabaseSelectionService()
    {
        _filePath = Path.Combine(AppContext.BaseDirectory, "database.config");
        if (File.Exists(_filePath))
        {
            SelectedServer = File.ReadAllText(_filePath).Trim();
        }
    }

    public string? SelectedServer { get; private set; }

    public async Task SaveSelectedServerAsync(string server)
    {
        SelectedServer = server;
        await File.WriteAllTextAsync(_filePath, server);
    }
}
