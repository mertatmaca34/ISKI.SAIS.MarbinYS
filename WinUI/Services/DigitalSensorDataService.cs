using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text.Json;
using Microsoft.AspNetCore.WebUtilities;
using WinUI.Constants;
using WinUI.Models;

namespace WinUI.Services;

public interface IDigitalSensorDataService
{
    Task<List<DigitalSensorDataDto>> GetByRangeAsync(DateTime startDate, DateTime endDate);
}

public class DigitalSensorDataService(HttpClient httpClient) : IDigitalSensorDataService
{
    private static readonly JsonSerializerOptions SerializerOptions = new() { PropertyNameCaseInsensitive = true };

    public async Task<List<DigitalSensorDataDto>> GetByRangeAsync(DateTime startDate, DateTime endDate)
    {
        var query = new Dictionary<string, string?>
        {
            ["startDate"] = startDate.ToString("O"),
            ["endDate"] = endDate.ToString("O")
        };

        var url = QueryHelpers.AddQueryString($"{DigitalSensorDataConstants.ApiUrl}/by-range", query);
        using var response = await httpClient.GetAsync(url);
        response.EnsureSuccessStatusCode();

        var items = await response.Content.ReadFromJsonAsync<List<DigitalSensorDataDto>>(SerializerOptions);
        return items ?? new List<DigitalSensorDataDto>();
    }
}
