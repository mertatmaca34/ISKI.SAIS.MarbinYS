using Microsoft.Extensions.DependencyInjection;
using WinUI.Constants;
using WinUI.Models;
using WinUI.Services;

namespace WinUI.Pages.Settings;

public partial class StationSettingsPage : UserControl
{
    private readonly IStationService _stationService;
    private readonly IStationInformationService _stationInformationService;
    private readonly ISaisApiService _saisApiService;

    public StationSettingsPage()
    {
        InitializeComponent();
        _stationService = Program.Services.GetRequiredService<IStationService>();
        _stationInformationService = Program.Services.GetRequiredService<IStationInformationService>();
        _saisApiService = Program.Services.GetRequiredService<ISaisApiService>();
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

        var existing = await _stationService.GetFirstAsync();

        int? connectionPort = int.TryParse(ConnectionPortTextBox.Text, out var cp) ? cp : null;

        StationDto? result;
        if (existing == null)
        {
            var command = new CreateStationCommand(
                stationId,
                stationId.ToString(),
                stationId.ToString(),
                (short)1,
                DateTime.Now,
                ConnectionDomainAddressTextBox.Text,
                connectionPort,
                ConnectionUserTextBox.Text,
                ConnectionPasswordTextBox.Text,
                string.Empty,
                DateTime.Now,
                DateTime.Now,
                string.Empty,
                string.Empty);

            result = await _stationService.CreateAsync(command);
        }
        else
        {
            var command = new UpdateStationCommand(
                stationId,
                existing.Code,
                existing.Name,
                existing.DataPeriodMinute,
                existing.LastDataDate,
                ConnectionDomainAddressTextBox.Text,
                connectionPort,
                ConnectionUserTextBox.Text,
                ConnectionPasswordTextBox.Text,
                existing.Company,
                existing.BirtDate,
                existing.SetupDate,
                existing.Address,
                existing.Software);

            result = await _stationService.UpdateAsync(command);
        }

        if (result != null)
        {
            var request = new SendHostChangedRequest
            {
                StationId = stationId,
                ConnectionUser = ConnectionUserTextBox.Text,
                ConnectionPassword = ConnectionPasswordTextBox.Text,
                ConnectionDomainAddress = ConnectionDomainAddressTextBox.Text,
                ConnectionPort = ConnectionPortTextBox.Text
            };

            try
            {
                var res = await _saisApiService.SendHostChangedAsync(request);

                if (res.result == true)
                {
                    MessageBox.Show($"İstasyon ayarları kaydedildi ve SAİS'e gönderildi. \nSİM API'den dönen cevap: {res.message}", StationConstants.InfoTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show($"İstasyon ayarları kaydedildi ancak SAİS'e gönderilemedi. \nSİM API'den dönen cevap: {res.message}", StationConstants.InfoTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"İstasyon ayarları kaydedildi ancak SAİS'e gönderilemedi: {ex.Message}", StationConstants.InfoTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
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
            var command = new UpdateStationCommand(
                station.StationId,
                info.Code,
                info.Name,
                info.DataPeriodMinute,
                info.LastDataDate,
                station.ConnectionDomainAddress,
                station.ConnectionPort,
                station.ConnectionUser,
                station.ConnectionPassword,
                info.Company,
                info.BirtDate,
                info.SetupDate,
                info.Address,
                info.Software);
            await _stationService.UpdateAsync(command);
            PopulateStationInfo(info);
        }
    }

    private void PopulateStationInfo(StationDto station)
    {
        StationIdTextBox.Text = station.StationId.ToString();
        CodeTextBox.Text = station.Code;
        StationNameTextBox.Text = station.Name;
        DataPeriodTextBox.Text = station.DataPeriodMinute?.ToString() ?? string.Empty;
        LastDataDateTextBox.Text = station.LastDataDate?.ToString("s") ?? string.Empty;
        CabinSoftwareAddressTextBox.Text = station.ConnectionDomainAddress;
        CabinSoftwarePortTextBox.Text = station.ConnectionPort?.ToString() ?? string.Empty;
        CabinSoftwareUsernameTextBox.Text = station.ConnectionUser;
        CabinSoftwarePasswordTextBox.Text = station.ConnectionPassword;
        OrganizationTextBox.Text = station.Company;
        StationSetupDateTextBox.Text = station.BirtDate?.ToString("d") ?? string.Empty;
        SoftwareSetupDateTextBox.Text = station.SetupDate?.ToString("d") ?? string.Empty;
        StationAddressTextBox.Text = station.Address;
        SoftwareTextBox.Text = station.Software;
    }

    private void PopulateStationSettings(StationDto station)
    {
        StationIdSettingTextBox.Text = station.StationId.ToString();
        ConnectionDomainAddressTextBox.Text = station.ConnectionDomainAddress;
        ConnectionPortTextBox.Text = station.ConnectionPort?.ToString() ?? string.Empty;
        ConnectionUserTextBox.Text = station.ConnectionUser;
        ConnectionPasswordTextBox.Text = station.ConnectionPassword;
    }
}
