using System;
using System.Net;
using System.Net.Http.Json;
using Domain.Entities;
using WinUI.Constants;

namespace WinUI.Services;

public interface ISendDataService
{
    Task CreateAsync(SendData data);
    Task<DateTime?> GetLatestReadTimeAsync();
}

public class SendDataService(HttpClient httpClient) : ISendDataService
{
    public async Task CreateAsync(SendData data)
    {
        using var response = await httpClient.PostAsJsonAsync(SendDataConstants.ApiUrl, data);
        response.EnsureSuccessStatusCode();
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
