using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text.Json;
using System.Windows.Forms;
using WinUI.Constants;
using WinUI.Services;

namespace WinUI.Pages.Settings;

public partial class ApiSettingsPage : UserControl
{
    private readonly IApiEndpointService _apiEndpointService;
    private readonly IConfiguration _configuration;
    private readonly HttpClient _remoteClient;
    private readonly HttpClient _localClient;
    private int? _apiEndpointId;
    private string? _token;

    private const string Ticket = "f9249e93-3093-4503-a913-09131c806f39";

    public ApiSettingsPage()
    {
        InitializeComponent();

        _apiEndpointService = Program.Services.GetRequiredService<IApiEndpointService>();
        _configuration = Program.Services.GetRequiredService<IConfiguration>();

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
                MessageBox.Show(ApiEndpointConstants.SavedMessage, ApiEndpointConstants.InfoTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            ResponseTextBox.Text = $"Status: {(int)response.StatusCode}\r\n{content}";
        }
        catch (Exception ex)
        {
            ResponseTextBox.Text = ex.Message;
        }
    }

    private async void LoginButton_Click(object? sender, EventArgs e)
    {
        try
        {
            var url = CombineUrl(ApiUrlTextBox.Text, "Security/login");
            var loginRequest = new
            {
                username = ApiUsernameTextBox.Text,
                password = ApiPasswordTextBox.Text,
                ticket = Ticket
            };

            using var response = await _remoteClient.PostAsJsonAsync(url, loginRequest);
            var content = await response.Content.ReadAsStringAsync();
            ResponseTextBox.Text = content;

            if (response.IsSuccessStatusCode)
            {
                var loginResponse = JsonSerializer.Deserialize<LoginResponse>(content, new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                });
                _token = loginResponse?.token;
            }
        }
        catch (Exception ex)
        {
            ResponseTextBox.Text = ex.Message;
        }
    }

    private async void RequestSampleButton_Click(object? sender, EventArgs e)
    {
        try
        {
            var body = new { ticket = Ticket };
            using var response = await _localClient.PostAsJsonAsync("api/sample/request-start", body);
            var content = await response.Content.ReadAsStringAsync();
            ResponseTextBox.Text = content;
        }
        catch (Exception ex)
        {
            ResponseTextBox.Text = ex.Message;
        }
    }

    private async void SendDiagnosticButton_Click(object? sender, EventArgs e)
    {
        try
        {
            var url = CombineUrl(ApiUrlTextBox.Text, "SendDiagnostic");
            using var request = new HttpRequestMessage(HttpMethod.Post, url);
            if (!string.IsNullOrEmpty(_token))
            {
                request.Headers.Add("token", _token);
            }
            var body = new
            {
                stationId = "1",
                ticket = Ticket,
                desc = "Deneme",
                stationAlarmId = "0",
                diagnosticDate = DateTime.Now.ToString("s")
            };
            request.Content = JsonContent.Create(body);
            using var response = await _remoteClient.SendAsync(request);
            var content = await response.Content.ReadAsStringAsync();
            ResponseTextBox.Text = content;
        }
        catch (Exception ex)
        {
            ResponseTextBox.Text = ex.Message;
        }
    }

    private static string CombineUrl(string baseUrl, string relative)
    {
        return $"{baseUrl.TrimEnd('/')}/{relative}";
    }

    private record LoginResponse(bool result, string message, string token, int expiresIn);
}
