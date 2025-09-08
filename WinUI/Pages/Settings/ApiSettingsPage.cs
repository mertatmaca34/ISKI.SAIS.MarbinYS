using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text.Json;
using System.Windows.Forms;
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
    private int? _apiEndpointId;


    public ApiSettingsPage()
    {
        InitializeComponent();

        _apiEndpointService = Program.Services.GetRequiredService<IApiEndpointService>();
        _configuration = Program.Services.GetRequiredService<IConfiguration>();
        _ticketService = Program.Services.GetRequiredService<ITicketService>();
        _stationService = Program.Services.GetRequiredService<IStationService>();

        var handler = new HttpClientHandler();
        handler.ServerCertificateCustomValidationCallback = HttpClientHandler.DangerousAcceptAnyServerCertificateValidator;
        _remoteClient = new HttpClient(handler);
        _localClient = new HttpClient();

        var baseUrl = _configuration["Api:BaseUrl"] ?? "https://localhost:62730";
        _localClient.BaseAddress = new Uri(baseUrl.TrimEnd('/'));

        Load += ApiSettingsPage_Load;
        SaveApiSettingsButton.Click += SaveApiSettingsButton_Click;
        SendServerRequestButton.Click += SendServerRequestButton_Click;
        LoginButton.Click += LoginButton_Click;
        RequestSampleButton.Click += RequestSampleButton_Click;
        SendDiagnosticButton.Click += SendDiagnosticButton_Click;
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
        }
    }

    private async void SaveApiSettingsButton_Click(object? sender, EventArgs e)
    {
        if (_apiEndpointId.HasValue)
        {
            var command = new UpdateApiEndpointCommand(_apiEndpointId.Value, ApiUrlTextBox.Text, ApiUsernameTextBox.Text, ApiPasswordTextBox.Text);
            var result = await _apiEndpointService.UpdateAsync(_apiEndpointId.Value, command);
            if (result != null)
            {
                MessageBox.Show(ApiEndpointConstants.UpdatedMessage, ApiEndpointConstants.InfoTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        else
        {
            var command = new CreateApiEndpointCommand(ApiUrlTextBox.Text, ApiUsernameTextBox.Text, ApiPasswordTextBox.Text);
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

            _remoteClient.DefaultRequestHeaders.Remove("AToken");
            _remoteClient.DefaultRequestHeaders.Add("AToken", JsonSerializer.Serialize(new AToken { TicketId = StationConstants.Ticket }));

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
}
