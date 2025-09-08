using System.Threading.Tasks;

namespace WinUI.Services;

public interface IDatabaseSelectionService
{
    string? SelectedServer { get; }
    Task SaveSelectedServerAsync(string server);
}
