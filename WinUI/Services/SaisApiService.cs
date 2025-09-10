using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text.Json;
using System.Threading.Tasks;
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

    public SaisApiService(HttpClient httpClient, ITicketService ticketService, IApiEndpointService apiEndpointService)
    {
        _httpClient = httpClient;
        _ticketService = ticketService;
        _apiEndpointService = apiEndpointService;
    }

    private async Task<string?> PrepareAsync()
    {
        await _ticketService.EnsureTicketAsync();
        var endpoint = await _apiEndpointService.GetFirstAsync();
        if (endpoint == null)
        {
            return null;
        }
        _httpClient.DefaultRequestHeaders.Remove("AToken");
        _httpClient.DefaultRequestHeaders.Add("AToken", JsonSerializer.Serialize(new AToken { TicketId = StationConstants.Ticket }));
        return endpoint.ApiAddress.TrimEnd('/');
    }

    public async Task<ResultStatus<DateTime>?> GetServerDateTimeAsync()
    {
        var baseUrl = await PrepareAsync();
        if (baseUrl == null) return null;
        using var response = await _httpClient.PostAsync($"{baseUrl}/SAIS/GetServerDateTime", null);
        response.EnsureSuccessStatusCode();
        return await response.Content.ReadFromJsonAsync<ResultStatus<DateTime>>();
    }

    public async Task<ResultStatus<StationDto>?> GetStationInformationAsync(Guid stationId)
    {
        var baseUrl = await PrepareAsync();
        if (baseUrl == null) return null;
        using var response = await _httpClient.PostAsync($"{baseUrl}/SAIS/GetStationInformation?stationId={stationId}", null);
        response.EnsureSuccessStatusCode();
        return await response.Content.ReadFromJsonAsync<ResultStatus<StationDto>>();
    }

    public async Task<ResultStatus?> SendHostChangedAsync(SendHostChangedRequest request)
    {
        var baseUrl = await PrepareAsync();
        if (baseUrl == null) return null;
        using var response = await _httpClient.PostAsJsonAsync($"{baseUrl}/SAIS/SendHostChanged", request);
        response.EnsureSuccessStatusCode();
        return await response.Content.ReadFromJsonAsync<ResultStatus>();
    }

    public async Task<ResultStatus<List<ChannelInfoDto>>?> GetChannelInformationByStationIdAsync(Guid stationId)
    {
        var baseUrl = await PrepareAsync();
        if (baseUrl == null) return null;
        using var response = await _httpClient.PostAsync($"{baseUrl}/SAIS/GetChannelInformationByStationId?stationId={stationId}", null);
        response.EnsureSuccessStatusCode();
        return await response.Content.ReadFromJsonAsync<ResultStatus<List<ChannelInfoDto>>>();
    }

    public async Task<ResultStatus?> UpdateChannelInformationAsync(UpdateChannelInformationRequest request)
    {
        var baseUrl = await PrepareAsync();
        if (baseUrl == null) return null;
        using var response = await _httpClient.PostAsJsonAsync($"{baseUrl}/SAIS/UpdateChannelInformation", request);
        response.EnsureSuccessStatusCode();
        return await response.Content.ReadFromJsonAsync<ResultStatus>();
    }

    public async Task<ResultStatus<List<ParameterDto>>?> GetParametersAsync()
    {
        var baseUrl = await PrepareAsync();
        if (baseUrl == null) return null;
        using var response = await _httpClient.PostAsync($"{baseUrl}/SAIS/GetParameters", null);
        response.EnsureSuccessStatusCode();
        return await response.Content.ReadFromJsonAsync<ResultStatus<List<ParameterDto>>>();
    }

    public async Task<ResultStatus<List<UnitDto>>?> GetUnitsAsync()
    {
        var baseUrl = await PrepareAsync();
        if (baseUrl == null) return null;
        using var response = await _httpClient.PostAsync($"{baseUrl}/SAIS/GetUnits", null);
        response.EnsureSuccessStatusCode();
        return await response.Content.ReadFromJsonAsync<ResultStatus<List<UnitDto>>>();
    }

    public async Task<ResultStatus?> SendDataAsync(ApiSendDataDto body)
    {
        var baseUrl = await PrepareAsync();
        if (baseUrl == null) return null;
        using var response = await _httpClient.PostAsJsonAsync($"{baseUrl}/SAIS/SendData", body);
        response.EnsureSuccessStatusCode();
        return await response.Content.ReadFromJsonAsync<ResultStatus>();
    }

    public async Task<ResultStatus<ApiDataResultDto>?> GetLastDataAsync(Guid stationId, int period)
    {
        var baseUrl = await PrepareAsync();
        if (baseUrl == null) return null;
        using var response = await _httpClient.PostAsync($"{baseUrl}/SAIS/GetLastData?stationId={stationId}&period={period}", null);
        response.EnsureSuccessStatusCode();
        return await response.Content.ReadFromJsonAsync<ResultStatus<ApiDataResultDto>>();
    }

    public async Task<ResultStatus<MissingDatesDto>?> GetMissingDatesAsync(Guid stationId)
    {
        var baseUrl = await PrepareAsync();
        if (baseUrl == null) return null;
        using var response = await _httpClient.PostAsync($"{baseUrl}/SAIS/GetMissingDates?stationId={stationId}", null);
        response.EnsureSuccessStatusCode();
        return await response.Content.ReadFromJsonAsync<ResultStatus<MissingDatesDto>>();
    }

    public async Task<ResultStatus<List<ApiDataResultDto>>?> GetDataByBetweenTwoDateAsync(Guid stationId, int period, DateTime startDate, DateTime endDate)
    {
        var baseUrl = await PrepareAsync();
        if (baseUrl == null) return null;
        string start = Uri.EscapeDataString(startDate.ToString("yyyy-MM-dd HH:mm:ss"));
        string end = Uri.EscapeDataString(endDate.ToString("yyyy-MM-dd HH:mm:ss"));
        using var response = await _httpClient.PostAsync($"{baseUrl}/SAIS/GetDataByBetweenTwoDate?stationId={stationId}&period={period}&startDate={start}&endDate={end}", null);
        response.EnsureSuccessStatusCode();
        return await response.Content.ReadFromJsonAsync<ResultStatus<List<ApiDataResultDto>>>();
    }

    public async Task<ResultStatus<List<DataStatusDto>>?> GetDataStatusDescriptionAsync()
    {
        var baseUrl = await PrepareAsync();
        if (baseUrl == null) return null;
        using var response = await _httpClient.PostAsync($"{baseUrl}/SAIS/GetDataStatusDescription", null);
        response.EnsureSuccessStatusCode();
        return await response.Content.ReadFromJsonAsync<ResultStatus<List<DataStatusDto>>>();
    }

    public async Task<ResultStatus<List<DiagnosticTypeDto>>?> GetDiagnosticTypesAsync()
    {
        var baseUrl = await PrepareAsync();
        if (baseUrl == null) return null;
        using var response = await _httpClient.PostAsync($"{baseUrl}/SAIS/GetDiagnosticTypes", null);
        response.EnsureSuccessStatusCode();
        return await response.Content.ReadFromJsonAsync<ResultStatus<List<DiagnosticTypeDto>>>();
    }

    public async Task<ResultStatus?> SendDiagnosticAsync(DiagnosticRequest request)
    {
        var baseUrl = await PrepareAsync();
        if (baseUrl == null) return null;
        using var response = await _httpClient.PostAsJsonAsync($"{baseUrl}/SAIS/SendDiagnostic", request);
        response.EnsureSuccessStatusCode();
        return await response.Content.ReadFromJsonAsync<ResultStatus>();
    }

    public async Task<ResultStatus?> SendPowerOffTimeAsync(PowerOffTimeRequest request)
    {
        var baseUrl = await PrepareAsync();
        if (baseUrl == null) return null;
        using var response = await _httpClient.PostAsJsonAsync($"{baseUrl}/SAIS/SendPowerOffTime", request);
        response.EnsureSuccessStatusCode();
        return await response.Content.ReadFromJsonAsync<ResultStatus>();
    }

    public async Task<ResultStatus?> SendDiagnosticWithTypeNoAsync(DiagnosticWithTypeRequest request)
    {
        var baseUrl = await PrepareAsync();
        if (baseUrl == null) return null;
        using var response = await _httpClient.PostAsJsonAsync($"{baseUrl}/SAIS/SendDiagnosticWithTypeNo", request);
        response.EnsureSuccessStatusCode();
        return await response.Content.ReadFromJsonAsync<ResultStatus>();
    }

    public async Task<ResultStatus?> SendCalibrationAsync(CalibrationRequest request)
    {
        var baseUrl = await PrepareAsync();
        if (baseUrl == null) return null;
        using var response = await _httpClient.PostAsJsonAsync($"{baseUrl}/SAIS/SendCalibration", request);
        response.EnsureSuccessStatusCode();
        return await response.Content.ReadFromJsonAsync<ResultStatus>();
    }

    public async Task<ResultStatus<List<CalibrationRecordDto>>?> GetCalibrationAsync(Guid stationId, DateTime startDate, DateTime endDate)
    {
        var baseUrl = await PrepareAsync();
        if (baseUrl == null) return null;
        string start = Uri.EscapeDataString(startDate.ToString("yyyy-MM-dd"));
        string end = Uri.EscapeDataString(endDate.ToString("yyyy-MM-dd"));
        using var response = await _httpClient.PostAsync($"{baseUrl}/SAIS/GetCalibration?stationId={stationId}&startDate={start}&endDate={end}", null);
        response.EnsureSuccessStatusCode();
        return await response.Content.ReadFromJsonAsync<ResultStatus<List<CalibrationRecordDto>>>();
    }

    public async Task<ResultStatus?> SampleRequestStartAsync(SampleRequestStart request)
    {
        var baseUrl = await PrepareAsync();
        if (baseUrl == null) return null;
        using var response = await _httpClient.PostAsJsonAsync($"{baseUrl}/SAIS/SampleRequestStart", request);
        response.EnsureSuccessStatusCode();
        return await response.Content.ReadFromJsonAsync<ResultStatus>();
    }

    public async Task<ResultStatus<string>?> SampleRequestLimitOverAsync(SampleRequestLimitOver request)
    {
        var baseUrl = await PrepareAsync();
        if (baseUrl == null) return null;
        using var response = await _httpClient.PostAsJsonAsync($"{baseUrl}/SAIS/SampleRequestLimitOver", request);
        response.EnsureSuccessStatusCode();
        return await response.Content.ReadFromJsonAsync<ResultStatus<string>>();
    }

    public async Task<ResultStatus?> SampleRequestCompleteAsync(SampleRequestComplete request)
    {
        var baseUrl = await PrepareAsync();
        if (baseUrl == null) return null;
        using var response = await _httpClient.PostAsJsonAsync($"{baseUrl}/SAIS/SampleRequestComplete", request);
        response.EnsureSuccessStatusCode();
        return await response.Content.ReadFromJsonAsync<ResultStatus>();
    }

    public async Task<ResultStatus?> SampleRequestErrorAsync(SampleRequestError request)
    {
        var baseUrl = await PrepareAsync();
        if (baseUrl == null) return null;
        using var response = await _httpClient.PostAsJsonAsync($"{baseUrl}/SAIS/SampleRequestError", request);
        response.EnsureSuccessStatusCode();
        return await response.Content.ReadFromJsonAsync<ResultStatus>();
    }
}
