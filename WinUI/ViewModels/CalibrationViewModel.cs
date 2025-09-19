using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using WinUI.Models;
using WinUI.Services;

namespace WinUI.ViewModels;

public partial class CalibrationViewModel : ObservableObject
{
    private readonly ICalibrationLimitService _limitService;
    private readonly ICalibrationMeasurementService _measurementService;

    public CalibrationViewModel(
        ICalibrationLimitService limitService,
        ICalibrationMeasurementService measurementService)
    {
        _limitService = limitService;
        _measurementService = measurementService;

        Limits = new ObservableCollection<CalibrationLimitDto>();
        LoadLimitsCommand = new AsyncRelayCommand(LoadLimitsAsync);
        SendMeasurementCommand = new AsyncRelayCommand(SendMeasurementAsync, CanSendMeasurement);
    }

    public ObservableCollection<CalibrationLimitDto> Limits { get; }

    [ObservableProperty]
    private CalibrationMeasurementDto? lastMeasurement;

    [ObservableProperty]
    private string statusMessage = "Kalibrasyon limitleri yüklenmedi.";

    [ObservableProperty]
    private bool isBusy;

    public IAsyncRelayCommand LoadLimitsCommand { get; }

    public IAsyncRelayCommand SendMeasurementCommand { get; }

    private async Task LoadLimitsAsync()
    {
        if (IsBusy)
        {
            return;
        }

        try
        {
            IsBusy = true;
            StatusMessage = "Limitler yükleniyor...";

            var result = await _limitService.GetListAsync();
            Limits.Clear();
            if (result is not null)
            {
                foreach (var limit in result.OrderBy(l => l.Parameter))
                {
                    Limits.Add(limit);
                }
            }

            StatusMessage = Limits.Count == 0
                ? "Limit bulunamadı."
                : $"{Limits.Count} limit güncellendi.";
        }
        catch (Exception ex)
        {
            StatusMessage = $"Limitler alınamadı: {ex.Message}";
        }
        finally
        {
            IsBusy = false;
            SendMeasurementCommand.NotifyCanExecuteChanged();
        }
    }

    private bool CanSendMeasurement()
    {
        return !IsBusy && Limits.Count > 0;
    }

    private async Task SendMeasurementAsync()
    {
        if (IsBusy)
        {
            return;
        }

        try
        {
            IsBusy = true;
            StatusMessage = "Ölçüm gönderiliyor...";

            var reference = Limits.First();
            var command = new CreateCalibrationMeasurementCommand(
                DateTime.Now,
                reference.Parameter,
                reference.ZeroRef,
                reference.ZeroRef + 0.2,
                0.2,
                0.05,
                reference.SpanRef,
                reference.SpanRef + 0.3,
                0.3,
                0.07,
                1.0,
                true);

            LastMeasurement = await _measurementService.CreateAsync(command);
            StatusMessage = LastMeasurement is null
                ? "Ölçüm gönderildi ancak geri bildirim alınamadı."
                : $"{LastMeasurement.Parameter} parametresi için ölçüm kaydedildi.";
        }
        catch (Exception ex)
        {
            StatusMessage = $"Ölçüm gönderilemedi: {ex.Message}";
        }
        finally
        {
            IsBusy = false;
            SendMeasurementCommand.NotifyCanExecuteChanged();
        }
    }
}
