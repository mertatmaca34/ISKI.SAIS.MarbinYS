using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using Domain.Entities;
using WinUI.Constants;
using WinUI.Models;
using WinUI.Services;

namespace WinUI.Pages.Settings;

public partial class ApiSettingsPage : UserControl
{
    private readonly IApiEndpointService _apiEndpointService;
    private readonly IConfiguration _configuration;
    private readonly HttpClient _remoteClient;
    private readonly HttpClient _localClient;
    private readonly ITicketService _ticketService;
    private readonly IStationService _stationService;
    private readonly ISaisApiService _saisApiService;
    private readonly ISendDataService _sendDataService;
    private int? _apiEndpointId;
    private readonly int[] _resendPeriodOptions = new[] { 24 * 60, 48 * 60, 7 * 24 * 60, 30 * 24 * 60, 90 * 24 * 60, 180 * 24 * 60, 365 * 24 * 60 };
    private readonly PeriodOption[] _periodOptions =
    {
        new("1 Dakika", 1),
        new("5 Dakika", 2),
        new("30 Dakika", 4),
        new("1 Saat", 8),
        new("1 Gün", 16)
    };
    private static readonly JsonSerializerOptions JsonWriteOptions = new() { WriteIndented = true };


    public ApiSettingsPage()
    {
        InitializeComponent();

        _apiEndpointService = Program.Services.GetRequiredService<IApiEndpointService>();
        _configuration = Program.Services.GetRequiredService<IConfiguration>();
        _ticketService = Program.Services.GetRequiredService<ITicketService>();
        _stationService = Program.Services.GetRequiredService<IStationService>();
        _saisApiService = Program.Services.GetRequiredService<ISaisApiService>();
        _sendDataService = Program.Services.GetRequiredService<ISendDataService>();

        var handler = new HttpClientHandler();
        handler.ServerCertificateCustomValidationCallback = HttpClientHandler.DangerousAcceptAnyServerCertificateValidator;
        _remoteClient = new HttpClient(handler);
        _localClient = new HttpClient();

        var baseUrl = _configuration["Api:BaseUrl"] ?? "https://localhost:62730";
        _localClient.BaseAddress = new Uri(baseUrl.TrimEnd('/'));

        Load += ApiSettingsPage_Load;
        SaveApiSettingsButton.Click += SaveApiSettingsButton_Click;
        SendServerRequestButton.Click += SendServerRequestButton_Click;
        RequestSampleButton.Click += RequestSampleButton_Click;
        SendDiagnosticButton.Click += SendDiagnosticButton_Click;
        GetLastDataButton.Click += GetLastDataButton_Click;
        GetHistoricalDataButton.Click += GetHistoricalDataButton_Click;

        ResendPeriodComboBox.Items.AddRange(new object[]
        {
            "Son 24 Saat",
            "Son 48 Saat",
            "Son 1 Hafta",
            "Son 1 Ay",
            "Son 3 Ay",
            "Son 6 Ay",
            "Son 1 Yıl"
        });
        ResendPeriodComboBox.SelectedIndex = 0;

        PeriodComboBox.Items.AddRange(_periodOptions);
        if (PeriodComboBox.Items.Count > 0)
        {
            PeriodComboBox.SelectedIndex = 0;
        }
    }

    private async void ApiSettingsPage_Load(object? sender, EventArgs e)
    {
        var endpoint = await _apiEndpointService.GetFirstAsync();
        if (endpoint != null)
        {
            _apiEndpointId = endpoint.Id;
            ApiUrlTextBox.Text = endpoint.ApiAddress;
            ApiUsernameTextBox.Text = endpoint.UserName;
            ApiPasswordTextBox.Text = endpoint.Password;
            if (endpoint.DataSendPeriodMinute.HasValue)
                DataSendPeriodNumericUpDown.Value = endpoint.DataSendPeriodMinute.Value;
            if (endpoint.ResendDataPeriodMinute.HasValue)
            {
                var idx = Array.IndexOf(_resendPeriodOptions, endpoint.ResendDataPeriodMinute.Value);
                if (idx >= 0)
                    ResendPeriodComboBox.SelectedIndex = idx;
            }
        }
    }

    private async void SaveApiSettingsButton_Click(object? sender, EventArgs e)
    {
        if (_apiEndpointId.HasValue)
        {
            var command = new UpdateApiEndpointCommand(
                _apiEndpointId.Value,
                ApiUrlTextBox.Text,
                ApiUsernameTextBox.Text,
                ApiPasswordTextBox.Text,
                (int)DataSendPeriodNumericUpDown.Value,
                _resendPeriodOptions[ResendPeriodComboBox.SelectedIndex]);
            var result = await _apiEndpointService.UpdateAsync(_apiEndpointId.Value, command);
            if (result != null)
            {
                MessageBox.Show(ApiEndpointConstants.UpdatedMessage, ApiEndpointConstants.InfoTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        else
        {
            var command = new CreateApiEndpointCommand(
                ApiUrlTextBox.Text,
                ApiUsernameTextBox.Text,
                ApiPasswordTextBox.Text,
                (int)DataSendPeriodNumericUpDown.Value,
                _resendPeriodOptions[ResendPeriodComboBox.SelectedIndex]);
            var result = await _apiEndpointService.CreateAsync(command);
            if (result != null)
            {
                _apiEndpointId = result.Id;
                MessageBox.Show(ApiEndpointConstants.SavedMessage, ApiEndpointConstants.InfoTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }

    private async void SendServerRequestButton_Click(object? sender, EventArgs e)
    {
        try
        {
            using var response = await _remoteClient.GetAsync(ApiUrlTextBox.Text.Trim());
            var content = await response.Content.ReadAsStringAsync();
            content = FormatContent(content);
            ResponseTextBox.Text = $"Status: {(int)response.StatusCode}\r\n{content}";
        }
        catch (Exception ex)
        {
            ResponseTextBox.Text = FormatContent(ex.Message);
        }
    }

    private async void LoginButton_Click(object? sender, EventArgs e)
    {
        try
        {
            var loginResult = await _ticketService.RefreshTicketAsync();
            var content = JsonSerializer.Serialize(loginResult, new JsonSerializerOptions { WriteIndented = true });
            ResponseTextBox.Text = content;
        }
        catch (Exception ex)
        {
            ResponseTextBox.Text = FormatContent(ex.Message);
        }
    }

    private async void RequestSampleButton_Click(object? sender, EventArgs e)
    {
        try
        {
            var body = new { ticket = StationConstants.Ticket };
            using var response = await _localClient.PostAsJsonAsync("api/sample/request-start", body);
            var content = await response.Content.ReadAsStringAsync();
            ResponseTextBox.Text = FormatContent(content);
        }
        catch (Exception ex)
        {
            ResponseTextBox.Text = FormatContent(ex.Message);
        }
    }

    private async void SendDiagnosticButton_Click(object? sender, EventArgs e)
    {
        try
        {
            await _ticketService.EnsureTicketAsync();

            var station = await _stationService.GetFirstAsync();
            if (station == null)
            {
                ResponseTextBox.Text = FormatContent("İstasyon bilgisi bulunamadı.");
                return;
            }

            if (!_ticketService.TryApplyTicket(_remoteClient.DefaultRequestHeaders))
            {
                ResponseTextBox.Text = FormatContent("Geçerli bir ticket bulunamadı.");
                return;
            }

            var url = CombineUrl(ApiUrlTextBox.Text, "SAIS/SendDiagnostic");
            using var request = new HttpRequestMessage(HttpMethod.Post, url);

            var body = new ApiDiagnosticDto
            {
                startDate = DateTime.Now,
                endDate = DateTime.Now,
                stationId = station.StationId,
                details = "Deneme",
                diagnosticTypeNo = 0
            };

            request.Content = JsonContent.Create(body);
            using var response = await _remoteClient.SendAsync(request);
            var content = await response.Content.ReadAsStringAsync();
            ResponseTextBox.Text = FormatContent(content);
        }
        catch (Exception ex)
        {
            ResponseTextBox.Text = FormatContent(ex.Message);
        }
    }

    private async void GetLastDataButton_Click(object? sender, EventArgs e)
    {
        await ExecuteSafeAsync(async () =>
        {
            var station = await _stationService.GetFirstAsync();
            if (station == null)
            {
                ResponseTextBox.Text = FormatContent("İstasyon bilgisi bulunamadı.");
                return;
            }

            int period = GetSelectedPeriodCode();
            var result = await _saisApiService.GetLastDataAsync(station.StationId, period);
            if (result == null)
            {
                ResponseTextBox.Text = FormatContent("Servisten yanıt alınamadı.");
                return;
            }

            ResponseTextBox.Text = FormatContent(JsonSerializer.Serialize(result, JsonWriteOptions));
        });
    }

    private async void GetHistoricalDataButton_Click(object? sender, EventArgs e)
    {
        await ExecuteSafeAsync(async () =>
        {
            var station = await _stationService.GetFirstAsync();
            if (station == null)
            {
                ResponseTextBox.Text = FormatContent("İstasyon bilgisi bulunamadı.");
                return;
            }

            int period = GetSelectedPeriodCode();
            DateTime endDate = DateTime.Now;
            DateTime? latestLocalReadTime = await _sendDataService.GetLatestReadTimeAsync();
            DateTime startDate = ResolveStartDate(station, latestLocalReadTime, endDate);

            var result = await _saisApiService.GetDataByBetweenTwoDateAsync(station.StationId, period, startDate, endDate);
            if (result == null)
            {
                ResponseTextBox.Text = FormatContent("Servisten yanıt alınamadı.");
                return;
            }

            if (result.objects is not { Count: > 0 })
            {
                ResponseTextBox.Text = FormatContent(JsonSerializer.Serialize(result, JsonWriteOptions));
                return;
            }

            List<ApiDataResultDto> newItems = FilterMeasurements(result.objects, latestLocalReadTime);
            foreach (var item in newItems)
            {
                var sendData = MapToSendData(item, station);
                await _sendDataService.CreateAsync(sendData);
            }

            var summary = new
            {
                result.result,
                result.message,
                period,
                startDate,
                endDate,
                fetchedCount = result.objects.Count,
                savedCount = newItems.Count
            };

            ResponseTextBox.Text = FormatContent(JsonSerializer.Serialize(summary, JsonWriteOptions));
        });
    }

    private static string CombineUrl(string baseUrl, string relative)
    {
        return $"{baseUrl.TrimEnd('/')}/{relative}";
    }

    private static string FormatContent(string content)
    {
        try
        {
            using var json = JsonDocument.Parse(content);
            return JsonSerializer.Serialize(json, new JsonSerializerOptions { WriteIndented = true });
        }
        catch (JsonException)
        {
            return content;
        }
    }

    private int GetSelectedPeriodCode()
    {
        if (PeriodComboBox.SelectedItem is PeriodOption option)
        {
            return option.Code;
        }

        return _periodOptions[0].Code;
    }

    private static List<ApiDataResultDto> FilterMeasurements(IEnumerable<ApiDataResultDto> items, DateTime? latestLocalReadTime)
    {
        return items
            .Where(item => latestLocalReadTime is null || item.ReadTime > latestLocalReadTime.Value)
            .OrderBy(item => item.ReadTime)
            .ToList();
    }

    private static SendData MapToSendData(ApiDataResultDto dto, StationDto station)
    {
        return new SendData
        {
            Stationid = station.StationId,
            Readtime = dto.ReadTime,
            SoftwareVersion = station.Software ?? string.Empty,
            AkisHizi = dto.AkisHizi ?? 0,
            AKM = dto.AKM ?? 0,
            CozunmusOksijen = dto.CozunmusOksijen ?? 0,
            Debi = dto.Debi ?? 0,
            DesarjDebi = null,
            HariciDebi = null,
            HariciDebi2 = null,
            KOi = dto.KOi ?? 0,
            pH = dto.pH ?? 0,
            Sicaklik = dto.Sicaklik ?? 0,
            Iletkenlik = 0,
            Period = dto.Period,
            AkisHizi_Status = dto.AkisHizi_Status ?? 0,
            AKM_Status = dto.AKM_Status ?? 0,
            CozunmusOksijen_Status = dto.CozunmusOksijen_Status ?? 0,
            Debi_Status = dto.Debi_Status ?? 0,
            DesarjDebi_Status = null,
            HariciDebi_Status = null,
            HariciDebi2_Status = null,
            KOi_Status = dto.KOi_Status ?? 0,
            pH_Status = dto.pH_Status ?? 0,
            Sicaklik_Status = dto.Sicaklik_Status ?? 0,
            Iletkenlik_Status = string.Empty,
            IsSent = true
        };
    }

    private async Task ExecuteSafeAsync(Func<Task> action)
    {
        try
        {
            await action();
        }
        catch (Exception ex)
        {
            ResponseTextBox.Text = FormatContent(ex.Message);
        }
    }

    private static DateTime ResolveStartDate(StationDto station, DateTime? latestLocalReadTime, DateTime endDate)
    {
        if (latestLocalReadTime.HasValue)
        {
            var candidate = latestLocalReadTime.Value.AddMinutes(1);
            if (candidate < endDate)
            {
                return candidate;
            }

            return endDate.AddMinutes(-1);
        }

        if (station.SetupDate.HasValue)
        {
            return station.SetupDate.Value;
        }

        if (station.BirtDate.HasValue)
        {
            return station.BirtDate.Value;
        }

        return endDate.AddYears(-1);
    }

    private sealed class PeriodOption
    {
        public PeriodOption(string displayName, int code)
        {
            DisplayName = displayName;
            Code = code;
        }

        public string DisplayName { get; }
        public int Code { get; }

        public override string ToString() => DisplayName;
    }
}
