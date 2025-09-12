using System.Net;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text.Json;
using Serilog;
using WinUI.Models;

namespace WinUI.Services;

public class PlcDataService : IPlcDataService
{
    private readonly HttpClient _httpClient;

    public PlcDataService(HttpClient httpClient)
    {
        _httpClient = httpClient;

        HttpClientHandler handler = new HttpClientHandler();
        handler.ServerCertificateCustomValidationCallback = HttpClientHandler.DangerousAcceptAnyServerCertificateValidator;
    }

    public async Task<PlcDataDto?> GetLatestAsync()
    {
        using var response = await _httpClient.GetAsync("api/plcdata");
        if (response.StatusCode == HttpStatusCode.NotFound)
        {
            Log.Warning("PLC bilgileri bulunamadı");
            throw new InvalidOperationException("PLC_NOT_CONFIGURED");
        }

        if (!response.IsSuccessStatusCode)
        {
            var error = await response.Content.ReadAsStringAsync();
            Log.Error("PLC API hatası {StatusCode}: {Error}", response.StatusCode, error);
            throw new HttpRequestException("PLC API request failed");
        }

        var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
        return await response.Content.ReadFromJsonAsync<PlcDataDto>(options);
    }
}
