using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text.Json;
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
    Task<ResultStatus?> SendDataAsync(ApiSendDataDto body);
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

    public SaisApiService(HttpClient httpClient, ITicketService ticketService, IApiEndpointService apiEndpointService, ILogger<SaisApiService> logger)
    {
        _httpClient = httpClient;
        _ticketService = ticketService;
        _apiEndpointService = apiEndpointService;
        _logger = logger;
    }

    private async Task<string?> PrepareAsync()
    {
        await _ticketService.EnsureTicketAsync();
        var endpoint = await _apiEndpointService.GetFirstAsync();
        if (endpoint == null)
        {
            _logger.LogWarning(LogMessages.SaisApiNotConfigured);
            return null;
        }
        _httpClient.DefaultRequestHeaders.Remove("AToken");
        _httpClient.DefaultRequestHeaders.Add("AToken", JsonSerializer.Serialize(new AToken { TicketId = StationConstants.Ticket }));
        return endpoint.ApiAddress.TrimEnd('/');
    }

    private async Task<T?> SendAsync<T>(Func<string, Task<HttpResponseMessage>> sendRequest)
    {
        var baseUrl = await PrepareAsync();
        if (baseUrl == null) return default;

        HttpResponseMessage response = await sendRequest(baseUrl);
        if (response.StatusCode == HttpStatusCode.Unauthorized)
        {
            _logger.LogWarning(LogMessages.SaisApiService.SessionNotFoundOrExpired);
            response.Dispose();
            await _ticketService.RefreshTicketAsync();
            baseUrl = await PrepareAsync();
            if (baseUrl == null) return default;
            response = await sendRequest(baseUrl);
        }

        try
        {
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadFromJsonAsync<T>();
        }
        finally
        {
            response.Dispose();
        }
    }

    public Task<ResultStatus<DateTime>?> GetServerDateTimeAsync() =>
        SendAsync<ResultStatus<DateTime>>(baseUrl => _httpClient.PostAsync($"{baseUrl}/SAIS/GetServerDateTime", null));

    public Task<ResultStatus<StationDto>?> GetStationInformationAsync(Guid stationId) =>
        SendAsync<ResultStatus<StationDto>>(baseUrl =>
            _httpClient.PostAsync($"{baseUrl}/SAIS/GetStationInformation?stationId={stationId}", null));

    public Task<ResultStatus?> SendHostChangedAsync(SendHostChangedRequest request) =>
        SendAsync<ResultStatus>(baseUrl =>
            _httpClient.PostAsJsonAsync($"{baseUrl}/SAIS/SendHostChanged", request));

    public Task<ResultStatus<List<ChannelInfoDto>>?> GetChannelInformationByStationIdAsync(Guid stationId) =>
        SendAsync<ResultStatus<List<ChannelInfoDto>>>(baseUrl =>
            _httpClient.PostAsync($"{baseUrl}/SAIS/GetChannelInformationByStationId?stationId={stationId}", null));

    public Task<ResultStatus?> UpdateChannelInformationAsync(UpdateChannelInformationRequest request) =>
        SendAsync<ResultStatus>(baseUrl =>
            _httpClient.PostAsJsonAsync($"{baseUrl}/SAIS/UpdateChannelInformation", request));

    public Task<ResultStatus<List<ParameterDto>>?> GetParametersAsync() =>
        SendAsync<ResultStatus<List<ParameterDto>>>(baseUrl =>
            _httpClient.PostAsync($"{baseUrl}/SAIS/GetParameters", null));

    public Task<ResultStatus<List<UnitDto>>?> GetUnitsAsync() =>
        SendAsync<ResultStatus<List<UnitDto>>>(baseUrl =>
            _httpClient.PostAsync($"{baseUrl}/SAIS/GetUnits", null));

    public Task<ResultStatus?> SendDataAsync(ApiSendDataDto body) =>
        SendAsync<ResultStatus>(baseUrl =>
            _httpClient.PostAsJsonAsync($"{baseUrl}/SAIS/SendData", body));

    public Task<ResultStatus<ApiDataResultDto>?> GetLastDataAsync(Guid stationId, int period) =>
        SendAsync<ResultStatus<ApiDataResultDto>>(baseUrl =>
            _httpClient.PostAsync($"{baseUrl}/SAIS/GetLastData?stationId={stationId}&period={period}", null));

    public Task<ResultStatus<MissingDatesDto>?> GetMissingDatesAsync(Guid stationId) =>
        SendAsync<ResultStatus<MissingDatesDto>>(baseUrl =>
            _httpClient.PostAsync($"{baseUrl}/SAIS/GetMissingDates?stationId={stationId}", null));

    public Task<ResultStatus<List<ApiDataResultDto>>?> GetDataByBetweenTwoDateAsync(Guid stationId, int period, DateTime startDate, DateTime endDate)
    {
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
            _httpClient.PostAsJsonAsync($"{baseUrl}/SAIS/SendDiagnostic", request));

    public Task<ResultStatus?> SendPowerOffTimeAsync(PowerOffTimeRequest request) =>
        SendAsync<ResultStatus>(baseUrl =>
            _httpClient.PostAsJsonAsync($"{baseUrl}/SAIS/SendPowerOffTime", request));

    public Task<ResultStatus?> SendDiagnosticWithTypeNoAsync(DiagnosticWithTypeRequest request) =>
        SendAsync<ResultStatus>(baseUrl =>
            _httpClient.PostAsJsonAsync($"{baseUrl}/SAIS/SendDiagnosticWithTypeNo", request));

    public Task<ResultStatus?> SendCalibrationAsync(CalibrationRequest request) =>
        SendAsync<ResultStatus>(baseUrl =>
            _httpClient.PostAsJsonAsync($"{baseUrl}/SAIS/SendCalibration", request));

    public Task<ResultStatus<List<CalibrationRecordDto>>?> GetCalibrationAsync(Guid stationId, DateTime startDate, DateTime endDate)
    {
        string start = Uri.EscapeDataString(startDate.ToString("yyyy-MM-dd"));
        string end = Uri.EscapeDataString(endDate.ToString("yyyy-MM-dd"));
        return SendAsync<ResultStatus<List<CalibrationRecordDto>>>(baseUrl =>
            _httpClient.PostAsync($"{baseUrl}/SAIS/GetCalibration?stationId={stationId}&startDate={start}&endDate={end}", null));
    }

    public Task<ResultStatus?> SampleRequestStartAsync(SampleRequestStart request) =>
        SendAsync<ResultStatus>(baseUrl =>
            _httpClient.PostAsJsonAsync($"{baseUrl}/SAIS/SampleRequestStart", request));

    public Task<ResultStatus<string>?> SampleRequestLimitOverAsync(SampleRequestLimitOver request) =>
        SendAsync<ResultStatus<string>>(baseUrl =>
            _httpClient.PostAsJsonAsync($"{baseUrl}/SAIS/SampleRequestLimitOver", request));

    public Task<ResultStatus?> SampleRequestCompleteAsync(SampleRequestComplete request) =>
        SendAsync<ResultStatus>(baseUrl =>
            _httpClient.PostAsJsonAsync($"{baseUrl}/SAIS/SampleRequestComplete", request));

    public Task<ResultStatus?> SampleRequestErrorAsync(SampleRequestError request) =>
        SendAsync<ResultStatus>(baseUrl =>
            _httpClient.PostAsJsonAsync($"{baseUrl}/SAIS/SampleRequestError", request));
}
