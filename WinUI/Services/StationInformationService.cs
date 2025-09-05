using System;
using System.Net.Http;
using System.Net.Http.Json;
using WinUI.Constants;
using WinUI.Models;

namespace WinUI.Services;

public interface IStationInformationService
{
    Task<StationDto?> GetAsync(Guid stationId);
}

public class StationInformationService : IStationInformationService
{
    private readonly HttpClient _httpClient;
    private readonly IApiEndpointService _apiEndpointService;

    private record StationInfoResponse(StationDto? Data);
    private record LoginResponse(bool result, string message, string token, int expiresIn);

    public StationInformationService(HttpClient httpClient, IApiEndpointService apiEndpointService)
    {
        _httpClient = httpClient;
        _apiEndpointService = apiEndpointService;
    }

    public async Task<StationDto?> GetAsync(Guid stationId)
    {
        var endpoint = await _apiEndpointService.GetFirstAsync();
        if (endpoint == null)
        {
            return null;
        }

        var loginUrl = $"{endpoint.ApiAddress.TrimEnd('/')}/Security/login";
        var loginRequest = new
        {
            username = endpoint.UserName,
            password = endpoint.Password,
            ticket = StationConstants.Ticket
        };

        using var loginResponse = await _httpClient.PostAsJsonAsync(loginUrl, loginRequest);
        loginResponse.EnsureSuccessStatusCode();
        var loginResult = await loginResponse.Content.ReadFromJsonAsync<LoginResponse>();

        using var request = new HttpRequestMessage(HttpMethod.Post, StationConstants.StationInfoApiUrl);
        if (!string.IsNullOrEmpty(loginResult?.token))
        {
            request.Headers.Add("token", loginResult.token);
        }

        var body = new { stationId, ticket = StationConstants.Ticket };
        request.Content = JsonContent.Create(body);

        using var response = await _httpClient.SendAsync(request);
        response.EnsureSuccessStatusCode();
        var result = await response.Content.ReadFromJsonAsync<StationInfoResponse>();
        return result?.Data;
    }
}
