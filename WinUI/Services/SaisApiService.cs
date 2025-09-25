using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using WinUI.Constants;
using WinUI.Models;

namespace WinUI.Services;

public interface ISaisApiService
{
    Task<ResultStatus<DateTime>?> GetServerDateTimeAsync();
    Task<ResultStatus<StationDto>?> GetStationInformationAsync(Guid stationId);
    Task<ResultStatus?> SendHostChangedAsync(SendHostChangedRequest request);
    Task<ResultStatus<List<ChannelInfoDto>>?> GetChannelInformationByStationIdAsync(Guid stationId);
    Task<ResultStatus?> UpdateChannelInformationAsync(UpdateChannelInformationRequest request);
    Task<ResultStatus<List<ParameterDto>>?> GetParametersAsync();
    Task<ResultStatus<List<UnitDto>>?> GetUnitsAsync();
    Task<ResultStatus<SendDataResult>> SendDataAsync(ApiSendDataDto body);
    Task<ResultStatus<ApiDataResultDto>?> GetLastDataAsync(Guid stationId, int period);
    Task<ResultStatus<MissingDatesDto>?> GetMissingDatesAsync(Guid stationId);
    Task<ResultStatus<List<ApiDataResultDto>>?> GetDataByBetweenTwoDateAsync(Guid stationId, int period, DateTime startDate, DateTime endDate);
    Task<ResultStatus<List<DataStatusDto>>?> GetDataStatusDescriptionAsync();
    Task<ResultStatus<List<DiagnosticTypeDto>>?> GetDiagnosticTypesAsync();
    Task<ResultStatus?> SendDiagnosticAsync(DiagnosticRequest request);
    Task<ResultStatus?> SendPowerOffTimeAsync(PowerOffTimeRequest request);
    Task<ResultStatus?> SendDiagnosticWithTypeNoAsync(DiagnosticWithTypeRequest request);
    Task<ResultStatus?> SendCalibrationAsync(CalibrationRequest request);
    Task<ResultStatus<List<CalibrationRecordDto>>?> GetCalibrationAsync(Guid stationId, DateTime startDate, DateTime endDate);
    Task<ResultStatus?> SampleRequestStartAsync(SampleRequestStart request);
    Task<ResultStatus<string>?> SampleRequestLimitOverAsync(SampleRequestLimitOver request);
    Task<ResultStatus?> SampleRequestCompleteAsync(SampleRequestComplete request);
    Task<ResultStatus?> SampleRequestErrorAsync(SampleRequestError request);
}

public class SaisApiService : ISaisApiService
{
    private readonly HttpClient _httpClient;
    private readonly ITicketService _ticketService;
    private readonly IApiEndpointService _apiEndpointService;
    private readonly ILogger<SaisApiService> _logger;
    private readonly IConnectionStatusService _connectionStatusService;
    private static readonly JsonSerializerOptions JsonOpts = new();

    public SaisApiService(HttpClient httpClient, ITicketService ticketService, IApiEndpointService apiEndpointService, ILogger<SaisApiService> logger, IConnectionStatusService connectionStatusService)
    {
        _httpClient = httpClient;
        _ticketService = ticketService;
        _apiEndpointService = apiEndpointService;
        _logger = logger;
        _connectionStatusService = connectionStatusService;
    }

    private Task<HttpResponseMessage> PostAsJsonAsync<TValue>(string requestUri, TValue value, CancellationToken cancellationToken = default) =>
        _httpClient.PostAsJsonAsync(requestUri, value, JsonOpts, cancellationToken);

    private async Task<string?> PrepareAsync()
    {
        try
        {
            await _ticketService.EnsureTicketAsync();
        }
        catch (HttpRequestException ex)
        {
            _connectionStatusService.ReportStatus(ConnectionComponent.SaisApi, ConnectionState.Unreachable, ex.Message);
            throw;
        }
        catch (TaskCanceledException ex)
        {
            _connectionStatusService.ReportStatus(ConnectionComponent.SaisApi, ConnectionState.Unreachable, ex.Message);
            throw;
        }
        catch (Exception ex)
        {
            _connectionStatusService.ReportStatus(ConnectionComponent.SaisApi, ConnectionState.NoAccess, ex.Message);
            throw;
        }
        var endpoint = await _apiEndpointService.GetFirstAsync();
        if (endpoint == null)
        {
            _logger.LogWarning(LogMessages.SaisApiNotConfigured);
            _connectionStatusService.ReportStatus(ConnectionComponent.SaisApi, ConnectionState.NotConfigured);
            return null;
        }
        var baseUrl = endpoint.ApiAddress?.TrimEnd('/');
        if (string.IsNullOrWhiteSpace(baseUrl))
        {
            _logger.LogWarning(LogMessages.SaisApiNotConfigured);
            _connectionStatusService.ReportStatus(ConnectionComponent.SaisApi, ConnectionState.NotConfigured);
            return null;
        }

        _httpClient.DefaultRequestHeaders.Accept.Clear();
        _httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

        if (!_ticketService.TryApplyTicket(_httpClient.DefaultRequestHeaders))
        {
            _logger.LogWarning(LogMessages.SaisApiService.TicketMissingOrExpired);
            _connectionStatusService.ReportStatus(ConnectionComponent.SaisApi, ConnectionState.NoAccess);
            return null;
        }

        _connectionStatusService.ReportStatus(ConnectionComponent.SaisApi, ConnectionState.Connected);
        return baseUrl;
    }

    private async Task<T?> SendAsync<T>(Func<string, Task<HttpResponseMessage>> sendRequest)
    {
        var baseUrl = await PrepareAsync();
        if (baseUrl == null) return default;

        HttpResponseMessage response = await SendWithStatusTrackingAsync(baseUrl, sendRequest);
        if (response.StatusCode == HttpStatusCode.Unauthorized)
        {
            _logger.LogWarning(LogMessages.SaisApiService.SessionNotFoundOrExpired);
            response.Dispose();
            await _ticketService.RefreshTicketAsync();
            baseUrl = await PrepareAsync();
            if (baseUrl == null) return default;
            response = await SendWithStatusTrackingAsync(baseUrl, sendRequest);
        }

        try
        {
            var (payload, rawContent) = await DeserializeAsync<T>(response);

            if (response.IsSuccessStatusCode)
            {
                _connectionStatusService.ReportStatus(ConnectionComponent.SaisApi, ConnectionState.Connected);
                return payload;
            }

            if (payload != null)
            {
                _connectionStatusService.ReportStatus(ConnectionComponent.SaisApi, ConnectionState.NoAccess, rawContent);
                _logger.LogWarning(
                    "SAIS API returned non-success status code {StatusCode}. Response: {ResponseContent}",
                    response.StatusCode,
                    rawContent);
                return payload;
            }

            _connectionStatusService.ReportStatus(ConnectionComponent.SaisApi, ConnectionState.NoAccess);
            _logger.LogWarning(
                "SAIS API returned non-success status code {StatusCode} with no readable payload.",
                response.StatusCode);

            response.EnsureSuccessStatusCode();
            return default;
        }
        finally
        {
            response.Dispose();
        }

        async Task<HttpResponseMessage> SendWithStatusTrackingAsync(string baseUrl, Func<string, Task<HttpResponseMessage>> sender)
        {
            try
            {
                return await sender(baseUrl);
            }
            catch (HttpRequestException ex)
            {
                _connectionStatusService.ReportStatus(ConnectionComponent.SaisApi, ConnectionState.Unreachable, ex.Message);
                throw;
            }
            catch (TaskCanceledException ex)
            {
                _connectionStatusService.ReportStatus(ConnectionComponent.SaisApi, ConnectionState.Unreachable, ex.Message);
                throw;
            }
        }
    }

    private async Task<(T? Payload, string Content)> DeserializeAsync<T>(HttpResponseMessage response)
    {
        var content = await response.Content.ReadAsStringAsync();
        if (string.IsNullOrWhiteSpace(content))
        {
            return (default, content);
        }

        try
        {
            var payload = JsonSerializer.Deserialize<T>(content, JsonOpts);
            return (payload, content);
        }
        catch (JsonException ex)
        {
            _logger.LogWarning(ex,
                "Failed to deserialize SAIS API response. StatusCode: {StatusCode}, Content: {ResponseContent}",
                response.StatusCode,
                content);
            return (default, content);
        }
    }

    public Task<ResultStatus<DateTime>?> GetServerDateTimeAsync() =>
        SendAsync<ResultStatus<DateTime>>(baseUrl => _httpClient.PostAsync($"{baseUrl}/SAIS/GetServerDateTime", null));

    public Task<ResultStatus<StationDto>?> GetStationInformationAsync(Guid stationId) =>
        SendAsync<ResultStatus<StationDto>>(baseUrl =>
            _httpClient.PostAsync($"{baseUrl}/SAIS/GetStationInformation?stationId={stationId}", null));

    public Task<ResultStatus?> SendHostChangedAsync(SendHostChangedRequest request) =>
        SendAsync<ResultStatus>(baseUrl =>
            PostAsJsonAsync($"{baseUrl}/SAIS/SendHostChanged", request));

    public Task<ResultStatus<List<ChannelInfoDto>>?> GetChannelInformationByStationIdAsync(Guid stationId) =>
        SendAsync<ResultStatus<List<ChannelInfoDto>>>(baseUrl =>
            _httpClient.PostAsync($"{baseUrl}/SAIS/GetChannelInformationByStationId?stationId={stationId}", null));

    public Task<ResultStatus?> UpdateChannelInformationAsync(UpdateChannelInformationRequest request) =>
        SendAsync<ResultStatus>(baseUrl =>
            PostAsJsonAsync($"{baseUrl}/SAIS/UpdateChannelInformation", request));

    public Task<ResultStatus<List<ParameterDto>>?> GetParametersAsync() =>
        SendAsync<ResultStatus<List<ParameterDto>>>(baseUrl =>
            _httpClient.PostAsync($"{baseUrl}/SAIS/GetParameters", null));

    public Task<ResultStatus<List<UnitDto>>?> GetUnitsAsync() =>
        SendAsync<ResultStatus<List<UnitDto>>>(baseUrl =>
            _httpClient.PostAsync($"{baseUrl}/SAIS/GetUnits", null));

    public Task<ResultStatus<SendDataResult>> SendDataAsync(ApiSendDataDto body) =>
        SendAsync<ResultStatus<SendDataResult>>(baseUrl =>
            PostAsJsonAsync($"{baseUrl}/SAIS/SendData", body));

    public Task<ResultStatus<ApiDataResultDto>?> GetLastDataAsync(Guid stationId, int period) =>
        SendAsync<ResultStatus<ApiDataResultDto>>(baseUrl =>
            _httpClient.PostAsync($"{baseUrl}/SAIS/GetLastData?stationId={stationId}&period={period}", null));

    public Task<ResultStatus<MissingDatesDto>?> GetMissingDatesAsync(Guid stationId) =>
        SendAsync<ResultStatus<MissingDatesDto>>(baseUrl =>
            _httpClient.PostAsync($"{baseUrl}/SAIS/GetMissingDates?stationId={stationId}", null));

    public Task<ResultStatus<List<ApiDataResultDto>>?> GetDataByBetweenTwoDateAsync(Guid stationId, int period, DateTime startDate, DateTime endDate)
    {
        _httpClient.Timeout  = TimeSpan.FromSeconds(300);
        string start = Uri.EscapeDataString(startDate.ToString("yyyy-MM-dd HH:mm:ss"));
        string end = Uri.EscapeDataString(endDate.ToString("yyyy-MM-dd HH:mm:ss"));
        return SendAsync<ResultStatus<List<ApiDataResultDto>>>(baseUrl =>
            _httpClient.PostAsync($"{baseUrl}/SAIS/GetDataByBetweenTwoDate?stationId={stationId}&period={period}&startDate={start}&endDate={end}", null));
    }

    public Task<ResultStatus<List<DataStatusDto>>?> GetDataStatusDescriptionAsync() =>
        SendAsync<ResultStatus<List<DataStatusDto>>>(baseUrl =>
            _httpClient.PostAsync($"{baseUrl}/SAIS/GetDataStatusDescription", null));

    public Task<ResultStatus<List<DiagnosticTypeDto>>?> GetDiagnosticTypesAsync() =>
        SendAsync<ResultStatus<List<DiagnosticTypeDto>>>(baseUrl =>
            _httpClient.PostAsync($"{baseUrl}/SAIS/GetDiagnosticTypes", null));

    public Task<ResultStatus?> SendDiagnosticAsync(DiagnosticRequest request) =>
        SendAsync<ResultStatus>(baseUrl =>
            PostAsJsonAsync($"{baseUrl}/SAIS/SendDiagnostic", request));

    public Task<ResultStatus?> SendPowerOffTimeAsync(PowerOffTimeRequest request) =>
        SendAsync<ResultStatus>(baseUrl =>
            PostAsJsonAsync($"{baseUrl}/SAIS/SendPowerOffTime", request));

    public Task<ResultStatus?> SendDiagnosticWithTypeNoAsync(DiagnosticWithTypeRequest request) =>
        SendAsync<ResultStatus>(baseUrl =>
            PostAsJsonAsync($"{baseUrl}/SAIS/SendDiagnosticWithTypeNo", request));

    public Task<ResultStatus?> SendCalibrationAsync(CalibrationRequest request) =>
        SendAsync<ResultStatus>(baseUrl =>
            PostAsJsonAsync($"{baseUrl}/SAIS/SendCalibration", request));

    public Task<ResultStatus<List<CalibrationRecordDto>>?> GetCalibrationAsync(Guid stationId, DateTime startDate, DateTime endDate)
    {
        string start = Uri.EscapeDataString(startDate.ToString("yyyy-MM-dd"));
        string end = Uri.EscapeDataString(endDate.ToString("yyyy-MM-dd"));
        return SendAsync<ResultStatus<List<CalibrationRecordDto>>>(baseUrl =>
            _httpClient.PostAsync($"{baseUrl}/SAIS/GetCalibration?stationId={stationId}&startDate={start}&endDate={end}", null));
    }

    public Task<ResultStatus?> SampleRequestStartAsync(SampleRequestStart request) =>
        SendAsync<ResultStatus>(baseUrl =>
            PostAsJsonAsync($"{baseUrl}/SAIS/SampleRequestStart", request));

    public Task<ResultStatus<string>?> SampleRequestLimitOverAsync(SampleRequestLimitOver request) =>
        SendAsync<ResultStatus<string>>(baseUrl =>
            PostAsJsonAsync($"{baseUrl}/SAIS/SampleRequestLimitOver", request));

    public Task<ResultStatus?> SampleRequestCompleteAsync(SampleRequestComplete request) =>
        SendAsync<ResultStatus>(baseUrl =>
            PostAsJsonAsync($"{baseUrl}/SAIS/SampleRequestComplete", request));

    public Task<ResultStatus?> SampleRequestErrorAsync(SampleRequestError request) =>
        SendAsync<ResultStatus>(baseUrl =>
            PostAsJsonAsync($"{baseUrl}/SAIS/SampleRequestError", request));
}
