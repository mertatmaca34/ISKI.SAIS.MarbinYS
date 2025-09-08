using System.Net.Http.Json;
using System.Linq;
using WinUI.Constants;
using WinUI.Models;

namespace WinUI.Services;

public record CreateApiEndpointCommand(string ApiAddress, string UserName, string Password, int? DataSendPeriodMinute, int? ResendDataPeriodMinute);

public record UpdateApiEndpointCommand(int Id, string ApiAddress, string UserName, string Password, int? DataSendPeriodMinute, int? ResendDataPeriodMinute);

public interface IApiEndpointService
{
    Task<ApiEndpointDto?> GetFirstAsync();
    Task<ApiEndpointDto?> CreateAsync(CreateApiEndpointCommand command);
    Task<ApiEndpointDto?> UpdateAsync(int id, UpdateApiEndpointCommand command);
}

public class ApiEndpointService(HttpClient httpClient) : IApiEndpointService
{
    public async Task<ApiEndpointDto?> GetFirstAsync()
    {
        var list = await httpClient.GetFromJsonAsync<List<ApiEndpointDto>>(ApiEndpointConstants.ApiUrl);
        return list?.FirstOrDefault();
    }

    public async Task<ApiEndpointDto?> CreateAsync(CreateApiEndpointCommand command)
    {
        using var response = await httpClient.PostAsJsonAsync(ApiEndpointConstants.ApiUrl, command);
        response.EnsureSuccessStatusCode();
        return await response.Content.ReadFromJsonAsync<ApiEndpointDto>();
    }

    public async Task<ApiEndpointDto?> UpdateAsync(int id, UpdateApiEndpointCommand command)
    {
        using var response = await httpClient.PutAsJsonAsync($"{ApiEndpointConstants.ApiUrl}/{id}", command);
        response.EnsureSuccessStatusCode();
        return await response.Content.ReadFromJsonAsync<ApiEndpointDto>();
    }
}
