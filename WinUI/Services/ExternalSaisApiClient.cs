using System;
using System.Collections.Generic;
using System.Globalization;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using WinUI.Constants;
using WinUI.Models;

namespace WinUI.Services;

public interface IExternalSaisApiClient
{
    Task<IReadOnlyList<ExternalSendDataDto>> GetSendDataAsync(DateTime start, DateTime end, CancellationToken cancellationToken = default);
    Task<IReadOnlyList<ExternalCalibrationRecordDto>> GetCalibrationsAsync(DateTime start, DateTime end, CancellationToken cancellationToken = default);
}

public class ExternalSaisApiClient(HttpClient httpClient) : IExternalSaisApiClient
{
    private static readonly JsonSerializerOptions SerializerOptions = new()
    {
        PropertyNameCaseInsensitive = true
    };

    public async Task<IReadOnlyList<ExternalSendDataDto>> GetSendDataAsync(DateTime start, DateTime end, CancellationToken cancellationToken = default)
    {
        var requestUri = BuildRequestUri(ExternalSaisApiConstants.SendDataEndpoint, start, end);
        using var response = await httpClient.GetAsync(requestUri, cancellationToken);
        response.EnsureSuccessStatusCode();

        var payload = await response.Content.ReadFromJsonAsync<List<ExternalSendDataDto>>(SerializerOptions, cancellationToken);
        return payload ?? new List<ExternalSendDataDto>();
    }

    public async Task<IReadOnlyList<ExternalCalibrationRecordDto>> GetCalibrationsAsync(DateTime start, DateTime end, CancellationToken cancellationToken = default)
    {
        var requestUri = BuildRequestUri(ExternalSaisApiConstants.SendCalibrationEndpoint, start, end);
        using var response = await httpClient.GetAsync(requestUri, cancellationToken);
        response.EnsureSuccessStatusCode();

        var payload = await response.Content.ReadFromJsonAsync<List<ExternalCalibrationRecordDto>>(SerializerOptions, cancellationToken);
        return payload ?? new List<ExternalCalibrationRecordDto>();
    }

    private static string BuildRequestUri(string endpoint, DateTime start, DateTime end)
    {
        var normalizedStart = NormalizeDate(start);
        var normalizedEnd = NormalizeDate(end);

        var startValue = Uri.EscapeDataString(normalizedStart.ToString("O", CultureInfo.InvariantCulture));
        var endValue = Uri.EscapeDataString(normalizedEnd.ToString("O", CultureInfo.InvariantCulture));

        return $"{endpoint}?{ExternalSaisApiConstants.StartQueryParameter}={startValue}&{ExternalSaisApiConstants.EndQueryParameter}={endValue}";
    }

    private static DateTime NormalizeDate(DateTime date)
    {
        return date.Kind switch
        {
            DateTimeKind.Unspecified => DateTime.SpecifyKind(date, DateTimeKind.Local),
            _ => date
        };
    }
}
