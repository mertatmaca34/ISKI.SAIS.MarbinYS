using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Domain.Entities;
using WinUI.Models;

namespace WinUI.Services;

public interface IExternalDataImportService
{
    Task<ExternalDataImportResult> ImportAsync(DateTime start, DateTime end, CancellationToken cancellationToken = default);
}

public class ExternalDataImportService(
    IExternalSaisApiClient apiClient,
    ISendDataService sendDataService,
    ICalibrationMeasurementService calibrationMeasurementService,
    IStationService stationService) : IExternalDataImportService
{
    private readonly IExternalSaisApiClient _apiClient = apiClient;
    private readonly ISendDataService _sendDataService = sendDataService;
    private readonly ICalibrationMeasurementService _calibrationMeasurementService = calibrationMeasurementService;
    private readonly IStationService _stationService = stationService;

    public async Task<ExternalDataImportResult> ImportAsync(DateTime start, DateTime end, CancellationToken cancellationToken = default)
    {
        var result = new ExternalDataImportResult();
        StationDto? station = null;

        var (startDate, endDate) = NormalizeRange(start, end);

        try
        {
            station = await _stationService.GetFirstAsync();
        }
        catch (Exception ex)
        {
            result.Errors.Add($"İstasyon bilgisi alınamadı: {ex.Message}");
        }

        await ImportSendDataAsync(result, station, startDate, endDate, cancellationToken);
        await ImportCalibrationsAsync(result, startDate, endDate, cancellationToken);

        return result;
    }

    private async Task ImportSendDataAsync(ExternalDataImportResult result, StationDto? station, DateTime startDate, DateTime endDate, CancellationToken cancellationToken)
    {
        IReadOnlyList<ExternalSendDataDto> remoteItems;

        try
        {
            remoteItems = await _apiClient.GetSendDataAsync(startDate, endDate, cancellationToken);
        }
        catch (Exception ex)
        {
            result.Errors.Add($"SendData verileri alınamadı: {ex.Message}");
            return;
        }

        result.SendDataFetchedCount = remoteItems.Count;

        foreach (var item in remoteItems)
        {
            cancellationToken.ThrowIfCancellationRequested();

            try
            {
                var stationId = item.StationId != Guid.Empty
                    ? item.StationId
                    : station?.StationId ?? Guid.Empty;

                if (stationId == Guid.Empty)
                {
                    result.Errors.Add($"{item.ReadTime:O} tarihli SendData kaydı için istasyon bilgisi bulunamadı.");
                    continue;
                }

                var existing = await _sendDataService.GetByReadTimeAsync(stationId, item.ReadTime);
                if (existing != null)
                {
                    continue;
                }

                var entity = MapToSendData(item, station, stationId);
                await _sendDataService.CreateAsync(entity);
                result.SendDataSavedCount++;
            }
            catch (Exception ex)
            {
                result.Errors.Add($"SendData kaydı kaydedilemedi ({item.ReadTime:O}): {ex.Message}");
            }
        }
    }

    private async Task ImportCalibrationsAsync(ExternalDataImportResult result, DateTime startDate, DateTime endDate, CancellationToken cancellationToken)
    {
        IReadOnlyList<ExternalCalibrationRecordDto> remoteItems;

        try
        {
            remoteItems = await _apiClient.GetCalibrationsAsync(startDate, endDate, cancellationToken);
        }
        catch (Exception ex)
        {
            result.Errors.Add($"Kalibrasyon verileri alınamadı: {ex.Message}");
            return;
        }

        result.CalibrationFetchedCount = remoteItems.Count;

        foreach (var item in remoteItems)
        {
            cancellationToken.ThrowIfCancellationRequested();

            try
            {
                var command = MapToCalibrationCommand(item);
                await _calibrationMeasurementService.CreateAsync(command);
                result.CalibrationSavedCount++;
            }
            catch (Exception ex)
            {
                result.Errors.Add($"Kalibrasyon kaydı kaydedilemedi ({item.CalibrationDate:O}): {ex.Message}");
            }
        }
    }

    private static SendData MapToSendData(ExternalSendDataDto dto, StationDto? station, Guid stationId)
    {
        return new SendData
        {
            Stationid = stationId,
            Readtime = dto.ReadTime,
            SoftwareVersion = string.IsNullOrWhiteSpace(dto.SoftwareVersion)
                ? station?.Software ?? string.Empty
                : dto.SoftwareVersion,
            AkisHizi = dto.AkisHizi ?? 0,
            AKM = dto.AKM ?? 0,
            CozunmusOksijen = dto.CozunmusOksijen ?? 0,
            Debi = dto.Debi ?? 0,
            DesarjDebi = dto.DesarjDebi,
            HariciDebi = dto.HariciDebi,
            HariciDebi2 = dto.HariciDebi2,
            KOi = dto.KOi ?? 0,
            pH = dto.pH ?? 0,
            Sicaklik = dto.Sicaklik ?? 0,
            Iletkenlik = dto.Iletkenlik ?? 0,
            Period = dto.Period ?? 0,
            AkisHizi_Status = dto.AkisHiziStatus ?? 0,
            AKM_Status = dto.AKMStatus ?? 0,
            CozunmusOksijen_Status = dto.CozunmusOksijenStatus ?? 0,
            Debi_Status = dto.DebiStatus ?? 0,
            DesarjDebi_Status = dto.DesarjDebiStatus,
            HariciDebi_Status = dto.HariciDebiStatus,
            HariciDebi2_Status = dto.HariciDebi2Status,
            KOi_Status = dto.KOiStatus ?? 0,
            pH_Status = dto.pHStatus ?? 0,
            Sicaklik_Status = dto.SicaklikStatus ?? 0,
            Iletkenlik_Status = dto.IletkenlikStatus ?? string.Empty,
            IsSent = dto.IsSent ?? true,
            SaatlikYikamaGecersiz = dto.SaatlikYikamaGecersiz ?? false,
            HaftalikYikamaGecersiz = dto.HaftalikYikamaGecersiz ?? false,
            KalibrasyonGecersiz = dto.KalibrasyonGecersiz ?? false,
            AkisHiziGecersiz = dto.AkisHiziGecersiz ?? false,
            GecersizDebi = dto.GecersizDebi ?? false,
            TekrarVeriGecersiz = dto.TekrarVeriGecersiz ?? false,
            GecersizOlcumBirimi = dto.GecersizOlcumBirimi ?? false
        };
    }

    private static CreateCalibrationMeasurementCommand MapToCalibrationCommand(ExternalCalibrationRecordDto dto)
    {
        bool isValid = (dto.Result ?? true) && (dto.ResultZero ?? true) && (dto.ResultSpan ?? true);

        return new CreateCalibrationMeasurementCommand(
            dto.CalibrationDate,
            string.IsNullOrWhiteSpace(dto.DBColumnName) ? "Bilinmiyor" : dto.DBColumnName,
            dto.ZeroRef ?? 0,
            dto.ZeroMeas ?? 0,
            dto.ZeroDiff ?? 0,
            dto.ZeroStd ?? 0,
            dto.SpanRef ?? 0,
            dto.SpanMeas ?? 0,
            dto.SpanDiff ?? 0,
            dto.SpanStd ?? 0,
            dto.ResultFactor ?? 0,
            isValid);
    }

    private static (DateTime Start, DateTime End) NormalizeRange(DateTime start, DateTime end)
    {
        var normalizedStart = start.Kind == DateTimeKind.Unspecified
            ? DateTime.SpecifyKind(start, DateTimeKind.Local)
            : start;

        var normalizedEnd = end.Kind == DateTimeKind.Unspecified
            ? DateTime.SpecifyKind(end, DateTimeKind.Local)
            : end;

        if (normalizedEnd < normalizedStart)
        {
            return (normalizedEnd, normalizedStart);
        }

        return (normalizedStart, normalizedEnd);
    }
}

public class ExternalDataImportResult
{
    public int SendDataFetchedCount { get; set; }
    public int SendDataSavedCount { get; set; }
    public int CalibrationFetchedCount { get; set; }
    public int CalibrationSavedCount { get; set; }

    public List<string> Errors { get; } = new();

    public bool IsSuccess => !Errors.Any();
}
