using System;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using WinUI.Models;
using WinUI.Services;

namespace WinUI.ViewModels;

public partial class ReportingViewModel : ObservableObject
{
    private readonly IMeasurementReportService _reportService;
    private readonly IReportExportService _exportService;

    public ReportingViewModel(IMeasurementReportService reportService, IReportExportService exportService)
    {
        _reportService = reportService;
        _exportService = exportService;

        Measurements = new ObservableCollection<ApiDataResultDto>();
        startDate = DateTimeOffset.Now.AddDays(-7);
        endDate = DateTimeOffset.Now;

        LoadReportsCommand = new AsyncRelayCommand(LoadReportsAsync);
        ExportToExcelCommand = new RelayCommand(ExportToExcel, CanExport);
    }

    [ObservableProperty]
    private DateTimeOffset startDate;

    [ObservableProperty]
    private DateTimeOffset endDate;

    [ObservableProperty]
    private string statusMessage = "Rapor yüklenmedi.";

    [ObservableProperty]
    private bool isBusy;

    public ObservableCollection<ApiDataResultDto> Measurements { get; }

    public IAsyncRelayCommand LoadReportsCommand { get; }

    public IRelayCommand ExportToExcelCommand { get; }

    private async Task LoadReportsAsync()
    {
        if (IsBusy)
        {
            return;
        }

        try
        {
            IsBusy = true;
            StatusMessage = "Rapor verileri yükleniyor...";

            var result = await _reportService.GetMeasurementsAsync(StartDate.DateTime, EndDate.DateTime);
            Measurements.Clear();
            foreach (var measurement in result.OrderByDescending(x => x.ReadTime))
            {
                Measurements.Add(measurement);
            }

            StatusMessage = Measurements.Count == 0
                ? "Seçilen aralıkta veri bulunamadı."
                : $"{Measurements.Count} satır yüklendi.";
        }
        catch (Exception ex)
        {
            StatusMessage = $"Rapor alınamadı: {ex.Message}";
        }
        finally
        {
            IsBusy = false;
            ExportToExcelCommand.NotifyCanExecuteChanged();
        }
    }

    private bool CanExport()
    {
        return Measurements.Count > 0;
    }

    private void ExportToExcel()
    {
        if (Measurements.Count == 0)
        {
            StatusMessage = "Dışa aktarılacak veri yok.";
            return;
        }

        try
        {
            var directory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            if (string.IsNullOrWhiteSpace(directory) || !Directory.Exists(directory))
            {
                directory = Path.GetTempPath();
            }

            var filePath = Path.Combine(directory, $"SaisMeasurements_{DateTime.Now:yyyyMMddHHmmss}.xlsx");
            _exportService.ExportMeasurementsToExcel(Measurements, filePath);
            StatusMessage = $"Excel dosyası oluşturuldu: {filePath}";
        }
        catch (Exception ex)
        {
            StatusMessage = $"Excel dışa aktarma başarısız: {ex.Message}";
        }
    }
}
