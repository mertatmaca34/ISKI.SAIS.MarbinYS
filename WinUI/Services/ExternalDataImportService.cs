using System;
using System.Collections.Concurrent;
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

    private const int DefaultParallelism = 4;

    private readonly record struct SendDataImportItem(ExternalSendDataDto Source, Guid StationId);

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

        if (remoteItems.Count == 0)
        {
            return;
        }

        var existingRecords = await FetchExistingSendDataAsync(startDate, endDate, cancellationToken, result);
        var existingLookup = new HashSet<(Guid StationId, DateTime ReadTime)>(existingRecords.Select(x => (x.Stationid, x.Readtime)));

        var errors = new ConcurrentBag<string>();
        var itemsToImport = new List<SendDataImportItem>(remoteItems.Count);

        foreach (var item in remoteItems)
        {
            cancellationToken.ThrowIfCancellationRequested();

            var stationId = ResolveStationId(item, station);
            if (stationId == Guid.Empty)
            {
                errors.Add($"{item.ReadTime:O} tarihli SendData kaydı için istasyon bilgisi bulunamadı.");
                continue;
            }

            if (existingLookup.Contains((stationId, item.ReadTime)))
            {
                continue;
            }

            itemsToImport.Add(new SendDataImportItem(item, stationId));
        }

        if (itemsToImport.Count == 0)
        {
            result.Errors.AddRange(errors);
            return;
        }

        var savedCount = 0;

        await Parallel.ForEachAsync(
            itemsToImport,
            new ParallelOptions
            {
                CancellationToken = cancellationToken,
                MaxDegreeOfParallelism = DefaultParallelism
            },
            async (candidate, token) =>
            {
                token.ThrowIfCancellationRequested();

                try
                {
                    var entity = MapToSendData(candidate.Source, station, candidate.StationId);
                    await _sendDataService.CreateAsync(entity);
                    Interlocked.Increment(ref savedCount);
                }
                catch (Exception ex)
                {
                    errors.Add($"SendData kaydı kaydedilemedi ({candidate.Source.ReadTime:O}): {ex.Message}");
                }
            });

        result.SendDataSavedCount += savedCount;
        result.Errors.AddRange(errors);
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

        if (remoteItems.Count == 0)
        {
            return;
        }

        var errors = new ConcurrentBag<string>();
        var savedCount = 0;

        await Parallel.ForEachAsync(
            remoteItems,
            new ParallelOptions
            {
                CancellationToken = cancellationToken,
                MaxDegreeOfParallelism = DefaultParallelism
            },
            async (item, token) =>
            {
                token.ThrowIfCancellationRequested();

                try
                {
                    var command = MapToCalibrationCommand(item);
                    await _calibrationMeasurementService.CreateAsync(command);
                    Interlocked.Increment(ref savedCount);
                }
                catch (Exception ex)
                {
                    errors.Add($"Kalibrasyon kaydı kaydedilemedi ({item.CalibrationDate:O}): {ex.Message}");
                }
            });

        result.CalibrationSavedCount += savedCount;
        result.Errors.AddRange(errors);
    }

    private async Task<List<SendDataRecord>> FetchExistingSendDataAsync(DateTime startDate, DateTime endDate, CancellationToken cancellationToken, ExternalDataImportResult result)
    {
        cancellationToken.ThrowIfCancellationRequested();

        try
        {
            var existing = await _sendDataService.GetByRangeAsync(startDate, endDate);
            return existing;
        }
        catch (Exception ex)
        {
            result.Errors.Add($"Mevcut SendData kayıtları alınamadı: {ex.Message}");
            return new List<SendDataRecord>();
        }
    }

    private static Guid ResolveStationId(ExternalSendDataDto item, StationDto? fallbackStation)
    {
        if (item.StationId != Guid.Empty)
        {
            return item.StationId;
        }

        if (fallbackStation?.StationId is { } stationId && stationId != Guid.Empty)
        {
            return stationId;
        }

        return Guid.Empty;
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
