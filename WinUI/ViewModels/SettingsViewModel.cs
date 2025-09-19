using System;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using WinUI.Models;
using WinUI.Services;

namespace WinUI.ViewModels;

public partial class SettingsViewModel : ObservableObject
{
    private readonly IStationService _stationService;
    private readonly IStationInformationService _stationInformationService;
    private readonly IApiEndpointService _apiEndpointService;
    private readonly IDatabaseSelectionService _databaseSelectionService;

    public SettingsViewModel(
        IStationService stationService,
        IStationInformationService stationInformationService,
        IApiEndpointService apiEndpointService,
        IDatabaseSelectionService databaseSelectionService)
    {
        _stationService = stationService;
        _stationInformationService = stationInformationService;
        _apiEndpointService = apiEndpointService;
        _databaseSelectionService = databaseSelectionService;

        Station = new StationDto
        {
            StationId = Guid.NewGuid(),
            Code = string.Empty,
            Name = string.Empty,
            ConnectionDomainAddress = string.Empty,
            ConnectionUser = string.Empty,
            ConnectionPassword = string.Empty,
            Company = string.Empty,
            Address = string.Empty,
            Software = string.Empty
        };

        ApiEndpoint = new ApiEndpointDto();
        DatabaseSettings = databaseSelectionService.Settings ?? new DatabaseSettings();

        LoadCommand = new AsyncRelayCommand(LoadAsync);
        SaveStationCommand = new AsyncRelayCommand(SaveStationAsync, CanSave);
        SaveApiSettingsCommand = new AsyncRelayCommand(SaveApiSettingsAsync, CanSave);
        SaveDatabaseSettingsCommand = new AsyncRelayCommand(SaveDatabaseSettingsAsync, CanSave);
    }

    [ObservableProperty]
    private StationDto station;

    [ObservableProperty]
    private ApiEndpointDto apiEndpoint;

    [ObservableProperty]
    private DatabaseSettings databaseSettings;

    [ObservableProperty]
    private string statusMessage = "Ayarlar yüklenmedi.";

    [ObservableProperty]
    private bool isBusy;

    public IAsyncRelayCommand LoadCommand { get; }

    public IAsyncRelayCommand SaveStationCommand { get; }

    public IAsyncRelayCommand SaveApiSettingsCommand { get; }

    public IAsyncRelayCommand SaveDatabaseSettingsCommand { get; }

    private bool CanSave()
    {
        return !IsBusy;
    }

    partial void OnIsBusyChanged(bool value)
    {
        SaveStationCommand.NotifyCanExecuteChanged();
        SaveApiSettingsCommand.NotifyCanExecuteChanged();
        SaveDatabaseSettingsCommand.NotifyCanExecuteChanged();
    }

    private async Task LoadAsync()
    {
        if (IsBusy)
        {
            return;
        }

        try
        {
            IsBusy = true;
            StatusMessage = "Ayarlar yükleniyor...";

            var station = await _stationService.GetFirstAsync();
            if (station is not null)
            {
                Station = station;
                var remoteInfo = await _stationInformationService.GetAsync(station.StationId);
                if (remoteInfo is not null)
                {
                    Station.LastDataDate = remoteInfo.LastDataDate;
                    Station.DataPeriodMinute = remoteInfo.DataPeriodMinute;
                }
            }

            var endpoint = await _apiEndpointService.GetFirstAsync();
            if (endpoint is not null)
            {
                ApiEndpoint = endpoint;
            }

            if (_databaseSelectionService.Settings is not null)
            {
                DatabaseSettings = _databaseSelectionService.Settings;
            }

            StatusMessage = "Ayarlar güncellendi.";
        }
        catch (Exception ex)
        {
            StatusMessage = $"Ayarlar yüklenemedi: {ex.Message}";
        }
        finally
        {
            IsBusy = false;
        }
    }

    private async Task SaveStationAsync()
    {
        if (IsBusy)
        {
            return;
        }

        try
        {
            IsBusy = true;
            StatusMessage = "İstasyon ayarları kaydediliyor...";

            if (Station.StationId == Guid.Empty)
            {
                Station.StationId = Guid.NewGuid();
            }

            var command = new UpdateStationCommand(
                Station.StationId,
                Station.Code,
                Station.Name,
                Station.DataPeriodMinute,
                Station.LastDataDate,
                Station.ConnectionDomainAddress,
                Station.ConnectionPort,
                Station.ConnectionUser,
                Station.ConnectionPassword,
                Station.Company,
                Station.BirtDate,
                Station.SetupDate,
                Station.Address,
                Station.Software);

            var updated = await _stationService.UpdateAsync(command);
            if (updated is not null)
            {
                Station = updated;
            }

            StatusMessage = "İstasyon bilgileri kaydedildi.";
        }
        catch (Exception ex)
        {
            StatusMessage = $"İstasyon kaydedilemedi: {ex.Message}";
        }
        finally
        {
            IsBusy = false;
        }
    }

    private async Task SaveApiSettingsAsync()
    {
        if (IsBusy)
        {
            return;
        }

        try
        {
            IsBusy = true;
            StatusMessage = "API ayarları kaydediliyor...";

            if (ApiEndpoint.Id == 0)
            {
                var created = await _apiEndpointService.CreateAsync(new CreateApiEndpointCommand(
                    ApiEndpoint.ApiAddress,
                    ApiEndpoint.UserName,
                    ApiEndpoint.Password,
                    ApiEndpoint.DataSendPeriodMinute,
                    ApiEndpoint.ResendDataPeriodMinute));

                if (created is not null)
                {
                    ApiEndpoint = created;
                }
            }
            else
            {
                var updated = await _apiEndpointService.UpdateAsync(ApiEndpoint.Id, new UpdateApiEndpointCommand(
                    ApiEndpoint.Id,
                    ApiEndpoint.ApiAddress,
                    ApiEndpoint.UserName,
                    ApiEndpoint.Password,
                    ApiEndpoint.DataSendPeriodMinute,
                    ApiEndpoint.ResendDataPeriodMinute));

                if (updated is not null)
                {
                    ApiEndpoint = updated;
                }
            }

            StatusMessage = "API ayarları kaydedildi.";
        }
        catch (Exception ex)
        {
            StatusMessage = $"API ayarları kaydedilemedi: {ex.Message}";
        }
        finally
        {
            IsBusy = false;
        }
    }

    private async Task SaveDatabaseSettingsAsync()
    {
        if (IsBusy)
        {
            return;
        }

        try
        {
            IsBusy = true;
            StatusMessage = "Veritabanı ayarları kaydediliyor...";
            await _databaseSelectionService.SaveDatabaseSettingsAsync(DatabaseSettings);
            StatusMessage = "Veritabanı ayarları kaydedildi.";
        }
        catch (Exception ex)
        {
            StatusMessage = $"Veritabanı ayarları kaydedilemedi: {ex.Message}";
        }
        finally
        {
            IsBusy = false;
        }
    }
}
