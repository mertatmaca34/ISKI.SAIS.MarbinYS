using System.Net.Http;
using System.Net.Http.Json;
using System.Text.Json;
using WinUI.Models;

namespace WinUI.Services;

public class PlcDataService : IPlcDataService
{
    private readonly HttpClient _httpClient;

    public PlcDataService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<PlcDataDto?> ReadAndSaveAsync()
    {
        using var response = await _httpClient.PostAsync("api/plcdata/read", null);
        response.EnsureSuccessStatusCode();
        var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
        return await response.Content.ReadFromJsonAsync<PlcDataDto>(options);
    }
}
