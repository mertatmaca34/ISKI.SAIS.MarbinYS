using System;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using WinUI.Models;
using WinUI.Services;

namespace WinUI.ViewModels;

public partial class HomeViewModel : ObservableObject
{
    private readonly IPlcDataService _plcDataService;
    private readonly IApiEndpointService _apiEndpointService;
    private readonly ITicketService _ticketService;

    public HomeViewModel(
        IPlcDataService plcDataService,
        IApiEndpointService apiEndpointService,
        ITicketService ticketService)
    {
        _plcDataService = plcDataService;
        _apiEndpointService = apiEndpointService;
        _ticketService = ticketService;

        RefreshCommand = new AsyncRelayCommand(RefreshAsync);
    }

    [ObservableProperty]
    private PlcDataDto? latestPlcData;

    [ObservableProperty]
    private ApiEndpointDto? apiEndpoint;

    [ObservableProperty]
    private string statusMessage = "Veriler yüklenmedi.";

    [ObservableProperty]
    private bool isBusy;

    public IAsyncRelayCommand RefreshCommand { get; }

    public string PlcSummary => LatestPlcData is null
        ? "Güncel PLC verisi bulunamadı."
        : $"Son Okuma: {LatestPlcData.Analog.Readtime:G}\nAKM: {LatestPlcData.Analog.Akm:F2} mg/L  •  KOİ: {LatestPlcData.Analog.Koi:F2} mg/L";

    partial void OnLatestPlcDataChanged(PlcDataDto? value)
    {
        OnPropertyChanged(nameof(PlcSummary));
    }

    private async Task RefreshAsync()
    {
        if (IsBusy)
        {
            return;
        }

        try
        {
            IsBusy = true;
            StatusMessage = "Veriler güncelleniyor...";

            await _ticketService.EnsureTicketAsync();
            ApiEndpoint = await _apiEndpointService.GetFirstAsync();
            LatestPlcData = await _plcDataService.GetLatestAsync();

            StatusMessage = ApiEndpoint is null
                ? "API yapılandırması bulunamadı."
                : $"API: {ApiEndpoint.ApiAddress}";
        }
        catch (Exception ex)
        {
            StatusMessage = $"Veri alınırken hata oluştu: {ex.Message}";
        }
        finally
        {
            IsBusy = false;
        }
    }
}
