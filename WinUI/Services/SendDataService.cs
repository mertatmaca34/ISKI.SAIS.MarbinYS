using System.Net.Http.Json;
using Domain.Entities;
using WinUI.Constants;

namespace WinUI.Services;

public interface ISendDataService
{
    Task CreateAsync(SendData data);
}

public class SendDataService(HttpClient httpClient) : ISendDataService
{
    public async Task CreateAsync(SendData data)
    {
        using var response = await httpClient.PostAsJsonAsync(SendDataConstants.ApiUrl, data);
        response.EnsureSuccessStatusCode();
    }
}
