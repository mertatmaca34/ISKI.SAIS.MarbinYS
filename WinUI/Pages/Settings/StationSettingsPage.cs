using System;
using System.Windows.Forms;
using Microsoft.Extensions.DependencyInjection;
using WinUI.Constants;
using WinUI.Services;

namespace WinUI.Pages.Settings;

public partial class StationSettingsPage : UserControl
{
    private readonly IStationService _stationService;

    public StationSettingsPage()
    {
        InitializeComponent();
        _stationService = Program.Services.GetRequiredService<IStationService>();
    }

    private void StationInfoTextChanged(object sender, EventArgs e)
    {
    }

    private async void SaveStationSettingsButton_Click(object? sender, EventArgs e)
    {
        if (!Guid.TryParse(StationIdTextBox.Text, out var stationId))
        {
            MessageBox.Show(StationConstants.InvalidStationIdMessage, StationConstants.ErrorTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        if (!int.TryParse(DataPeriodTextBox.Text, out var dataPeriod))
        {
            MessageBox.Show(StationConstants.InvalidDataPeriodMessage, StationConstants.ErrorTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        if (!DateTime.TryParse(LastDataDateTextBox.Text, out var lastDataDate) ||
            !DateTime.TryParse(StationSetupDateTextBox.Text, out var birthDate) ||
            !DateTime.TryParse(SoftwareSetupDateTextBox.Text, out var setupDate))
        {
            MessageBox.Show(StationConstants.InvalidDateMessage, StationConstants.ErrorTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        var command = new CreateStationCommand(
            stationId,
            CodeTextBox.Text,
            StationNameTextBox.Text,
            dataPeriod,
            lastDataDate,
            CabinSoftwareAddressTextBox.Text,
            ConnectionPortTextBox.Text,
            ConnectionUserTextBox.Text,
            ConnectionPasswordTextBox.Text,
            OrganizationTextBox.Text,
            birthDate,
            setupDate,
            StationAddressTextBox.Text,
            SoftwareTextBox.Text);

        var result = await _stationService.CreateAsync(command);
        if (result != null)
        {
            MessageBox.Show(string.Format(StationConstants.StationSavedMessage, result.Name), StationConstants.InfoTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
