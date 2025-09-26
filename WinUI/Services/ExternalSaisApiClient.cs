using System.Collections.Generic;
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
    Task<IReadOnlyList<ExternalSendDataDto>> GetSendDataAsync(CancellationToken cancellationToken = default);
    Task<IReadOnlyList<ExternalCalibrationRecordDto>> GetCalibrationsAsync(CancellationToken cancellationToken = default);
}

public class ExternalSaisApiClient(HttpClient httpClient) : IExternalSaisApiClient
{
    private static readonly JsonSerializerOptions SerializerOptions = new()
    {
        PropertyNameCaseInsensitive = true
    };

    public async Task<IReadOnlyList<ExternalSendDataDto>> GetSendDataAsync(CancellationToken cancellationToken = default)
    {
        using var response = await httpClient.GetAsync(ExternalSaisApiConstants.SendDataEndpoint, cancellationToken);
        response.EnsureSuccessStatusCode();

        var payload = await response.Content.ReadFromJsonAsync<List<ExternalSendDataDto>>(SerializerOptions, cancellationToken);
        return payload ?? new List<ExternalSendDataDto>();
    }

    public async Task<IReadOnlyList<ExternalCalibrationRecordDto>> GetCalibrationsAsync(CancellationToken cancellationToken = default)
    {
        using var response = await httpClient.GetAsync(ExternalSaisApiConstants.SendCalibrationEndpoint, cancellationToken);
        response.EnsureSuccessStatusCode();

        var payload = await response.Content.ReadFromJsonAsync<List<ExternalCalibrationRecordDto>>(SerializerOptions, cancellationToken);
        return payload ?? new List<ExternalCalibrationRecordDto>();
    }
}
