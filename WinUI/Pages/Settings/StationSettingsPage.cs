using System;
using System.Windows.Forms;
using Microsoft.Extensions.DependencyInjection;
using WinUI.Constants;
using WinUI.Models;
using WinUI.Services;

namespace WinUI.Pages.Settings;

public partial class StationSettingsPage : UserControl
{
    private readonly IStationService _stationService;
    private readonly IStationInformationService _stationInformationService;

    public StationSettingsPage()
    {
        InitializeComponent();
        _stationService = Program.Services.GetRequiredService<IStationService>();
        _stationInformationService = Program.Services.GetRequiredService<IStationInformationService>();
    }

    protected override async void OnLoad(EventArgs e)
    {
        base.OnLoad(e);
        var station = await _stationService.GetFirstAsync();
        if (station != null)
        {
            PopulateStationInfo(station);
            PopulateStationSettings(station);
        }
    }

    private void StationInfoTextChanged(object sender, EventArgs e)
    {
    }

    private async void SaveStationSettingsButton_Click(object? sender, EventArgs e)
    {
        if (!Guid.TryParse(StationIdSettingTextBox.Text, out var stationId))
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

    private async void FetchStationButton_Click(object? sender, EventArgs e)
    {
        var station = await _stationService.GetFirstAsync();
        if (station == null)
        {
            MessageBox.Show(StationConstants.StationSettingsRequiredMessage, StationConstants.InfoTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        var info = await _stationInformationService.GetAsync(station.StationId);
        if (info != null)
        {
            PopulateStationInfo(info);
        }
    }

    private void PopulateStationInfo(StationDto station)
    {
        StationIdTextBox.Text = station.StationId.ToString();
        CodeTextBox.Text = station.Code;
        StationNameTextBox.Text = station.Name;
        DataPeriodTextBox.Text = station.DataPeriodMinute.ToString();
        LastDataDateTextBox.Text = station.LastDataDate.ToString("s");
        CabinSoftwareAddressTextBox.Text = station.ConnectionDomainAddress;
        CabinSoftwarePortTextBox.Text = station.ConnectionPort;
        CabinSoftwareUsernameTextBox.Text = station.ConnectionUser;
        CabinSoftwarePasswordTextBox.Text = station.ConnectionPassword;
        OrganizationTextBox.Text = station.Company;
        StationSetupDateTextBox.Text = station.BirtDate.ToString("d");
        SoftwareSetupDateTextBox.Text = station.SetupDate.ToString("d");
        StationAddressTextBox.Text = station.Address;
        SoftwareTextBox.Text = station.Software;
    }

    private void PopulateStationSettings(StationDto station)
    {
        StationIdSettingTextBox.Text = station.StationId.ToString();
        ConnectionDomainAddressTextBox.Text = station.ConnectionDomainAddress;
        ConnectionPortTextBox.Text = station.ConnectionPort;
        ConnectionUserTextBox.Text = station.ConnectionUser;
        ConnectionPasswordTextBox.Text = station.ConnectionPassword;
    }
}
