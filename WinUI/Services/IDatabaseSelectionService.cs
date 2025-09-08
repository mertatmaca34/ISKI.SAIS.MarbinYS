using System.Threading.Tasks;
using WinUI.Models;

namespace WinUI.Services;

public interface IDatabaseSelectionService
{
    DatabaseSettings? Settings { get; }
    Task SaveDatabaseSettingsAsync(DatabaseSettings settings);
}
