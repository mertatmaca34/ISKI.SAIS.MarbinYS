using System;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Domain.Entities;
using WinUI.Models;
using WinUI.Services;

namespace WinUI.ViewModels;

public partial class SimulationViewModel : ObservableObject
{
    private readonly ISendDataService _sendDataService;
    private readonly IPlcDataService _plcDataService;

    public SimulationViewModel(ISendDataService sendDataService, IPlcDataService plcDataService)
    {
        _sendDataService = sendDataService;
        _plcDataService = plcDataService;

        LoadDataCommand = new AsyncRelayCommand(LoadDataAsync);
        SendSimulationCommand = new AsyncRelayCommand(SendSimulationAsync, CanSendSimulation);
    }

    [ObservableProperty]
    private PlcDataDto? latestPlcData;

    [ObservableProperty]
    private string statusMessage = "Simülasyon verisi hazır değil.";

    [ObservableProperty]
    private bool isBusy;

    public IAsyncRelayCommand LoadDataCommand { get; }

    public IAsyncRelayCommand SendSimulationCommand { get; }

    private bool CanSendSimulation()
    {
        return !IsBusy && LatestPlcData is not null;
    }

    partial void OnIsBusyChanged(bool value)
    {
        SendSimulationCommand.NotifyCanExecuteChanged();
    }

    partial void OnLatestPlcDataChanged(PlcDataDto? value)
    {
        SendSimulationCommand.NotifyCanExecuteChanged();
    }

    private async Task LoadDataAsync()
    {
        if (IsBusy)
        {
            return;
        }

        try
        {
            IsBusy = true;
            StatusMessage = "PLC verisi çekiliyor...";
            LatestPlcData = await _plcDataService.GetLatestAsync();
            StatusMessage = LatestPlcData is null
                ? "PLC verisi bulunamadı."
                : "Veri hazır. Simülasyonu başlatabilirsiniz.";
        }
        catch (Exception ex)
        {
            StatusMessage = $"Veri alınamadı: {ex.Message}";
        }
        finally
        {
            IsBusy = false;
        }
    }

    private async Task SendSimulationAsync()
    {
        if (IsBusy || LatestPlcData is null)
        {
            return;
        }

        try
        {
            IsBusy = true;
            StatusMessage = "Simülasyon gönderiliyor...";

            var analog = LatestPlcData.Analog;
            var data = new SendData
            {
                Stationid = Guid.NewGuid(),
                Readtime = DateTime.Now,
                SoftwareVersion = "Simulation",
                AkisHizi = analog.AkisHizi,
                AKM = analog.Akm,
                CozunmusOksijen = analog.CozunmusOksijen,
                Debi = analog.Debi,
                DesarjDebi = analog.DesarjDebi,
                HariciDebi = analog.HariciDebi,
                HariciDebi2 = analog.HariciDebi2,
                KOi = analog.Koi,
                pH = analog.Ph,
                Sicaklik = analog.Sicaklik,
                Iletkenlik = analog.Iletkenlik,
                Period = 1,
                AkisHizi_Status = 1,
                AKM_Status = 1,
                CozunmusOksijen_Status = 1,
                Debi_Status = 1,
                DesarjDebi_Status = 1,
                HariciDebi_Status = 1,
                HariciDebi2_Status = 1,
                KOi_Status = 1,
                pH_Status = 1,
                Sicaklik_Status = 1,
                Iletkenlik_Status = "1",
                SaatlikYikamaGecersiz = false,
                HaftalikYikamaGecersiz = false,
                KalibrasyonGecersiz = false,
                AkisHiziGecersiz = false,
                GecersizDebi = false,
                TekrarVeriGecersiz = false,
                GecersizOlcumBirimi = false,
            };

            await _sendDataService.CreateAsync(data);
            StatusMessage = "Simülasyon verisi gönderildi.";
        }
        catch (Exception ex)
        {
            StatusMessage = $"Simülasyon başarısız: {ex.Message}";
        }
        finally
        {
            IsBusy = false;
        }
    }
}
