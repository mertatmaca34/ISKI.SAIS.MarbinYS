using System.Collections.Generic;
using System.Threading.Tasks;
using WinUI.Models;

namespace WinUI.Services;

public interface IDatabaseSearchEngine
{
    Task<IEnumerable<string>> SearchServersAsync();
    Task<DatabaseInfo?> GetDatabaseInfoAsync(string server);
}
