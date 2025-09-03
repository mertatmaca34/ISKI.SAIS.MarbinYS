using Microsoft.Extensions.DependencyInjection;
using System;
using System.Windows.Forms;
using WinUI.Constants;
using WinUI.Services;

namespace WinUI.Pages.Settings;

public partial class ApiSettingsPage : UserControl
{
    private readonly IApiEndpointService _apiEndpointService;
    private int? _apiEndpointId;

    public ApiSettingsPage()
    {
        InitializeComponent();
        _apiEndpointService = Program.Services.GetRequiredService<IApiEndpointService>();
        Load += ApiSettingsPage_Load;
        SaveApiSettingsButton.Click += SaveApiSettingsButton_Click;
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
}
