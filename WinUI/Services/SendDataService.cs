using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http.Json;
using System.Text.Json;
using Domain.Entities;
using Microsoft.AspNetCore.WebUtilities;
using WinUI.Constants;
using WinUI.Models;

namespace WinUI.Services;

public interface ISendDataService
{
    Task CreateAsync(SendData data);
    Task<SendDataRecord?> GetByReadTimeAsync(Guid stationId, DateTime readTime);
    Task<bool> UpdateStatusAsync(SendDataStatusUpdateRequest request);
    Task<DateTime?> GetLatestReadTimeAsync();
    Task<List<SendDataRecord>> GetByRangeAsync(DateTime startDate, DateTime endDate);
}

public class SendDataService(HttpClient httpClient) : ISendDataService
{
    private static readonly JsonSerializerOptions SerializerOptions = new() { PropertyNameCaseInsensitive = true };

    public async Task CreateAsync(SendData data)
    {
        using var response = await httpClient.PostAsJsonAsync(SendDataConstants.ApiUrl, data);
        response.EnsureSuccessStatusCode();
    }

    public async Task<SendDataRecord?> GetByReadTimeAsync(Guid stationId, DateTime readTime)
    {
        var query = new Dictionary<string, string?>
        {
            ["stationId"] = stationId.ToString(),
            ["readTime"] = readTime.ToString("O")
        };

        var url = QueryHelpers.AddQueryString($"{SendDataConstants.ApiUrl}/by-station-and-readtime", query);
        using var response = await httpClient.GetAsync(url);
        if (response.StatusCode == HttpStatusCode.NotFound)
            return null;

        response.EnsureSuccessStatusCode();
        return await response.Content.ReadFromJsonAsync<SendDataRecord>(SerializerOptions);
    }

    public async Task<bool> UpdateStatusAsync(SendDataStatusUpdateRequest request)
    {
        using var response = await httpClient.PutAsJsonAsync($"{SendDataConstants.ApiUrl}/{request.Id}/status", request);
        if (response.StatusCode == HttpStatusCode.NotFound)
            return false;

        response.EnsureSuccessStatusCode();
        return true;
    }

    public async Task<List<SendDataRecord>> GetByRangeAsync(DateTime startDate, DateTime endDate)
    {
        var query = new Dictionary<string, string?>
        {
            ["startDate"] = startDate.ToString("O"),
            ["endDate"] = endDate.ToString("O")
        };

        var url = QueryHelpers.AddQueryString($"{SendDataConstants.ApiUrl}/by-range", query);
        using var response = await httpClient.GetAsync(url);
        response.EnsureSuccessStatusCode();

        var items = await response.Content.ReadFromJsonAsync<List<SendDataRecord>>(SerializerOptions);
        return items ?? new List<SendDataRecord>();
    }
    public async Task<DateTime?> GetLatestReadTimeAsync()
    {
        using var response = await httpClient.GetAsync($"{SendDataConstants.ApiUrl}/latest-readtime");
        if (response.StatusCode == HttpStatusCode.NotFound)
        {
            return null;
        }

        response.EnsureSuccessStatusCode();
        return await response.Content.ReadFromJsonAsync<DateTime?>();
    }
}
