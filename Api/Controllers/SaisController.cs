using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Api.Dtos.Sais;
using Api.Dtos.Sais.Requests;
using Api.Dtos.Sais.Responses;
using Api.Helpers;
using Infrastructure.Remote.SAIS;
using Infrastructure.Remote.SAIS.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class SaisController : ControllerBase
{
    private readonly ISaisTimeClient _timeClient;
    private readonly ISaisStationClient _stationClient;
    private readonly ISaisChannelClient _channelClient;
    private readonly ISaisGeneralInformationClient _generalInformationClient;
    private readonly ISaisDataClient _dataClient;
    private readonly ISaisDiagnosticClient _diagnosticClient;
    private readonly ISaisCalibrationClient _calibrationClient;
    private readonly ISaisSampleClient _sampleClient;
    private readonly ILogger<SaisController> _logger;

    public SaisController(
        ISaisTimeClient timeClient,
        ISaisStationClient stationClient,
        ISaisChannelClient channelClient,
        ISaisGeneralInformationClient generalInformationClient,
        ISaisDataClient dataClient,
        ISaisDiagnosticClient diagnosticClient,
        ISaisCalibrationClient calibrationClient,
        ISaisSampleClient sampleClient,
        ILogger<SaisController> logger)
    {
        _timeClient = timeClient;
        _stationClient = stationClient;
        _channelClient = channelClient;
        _generalInformationClient = generalInformationClient;
        _dataClient = dataClient;
        _diagnosticClient = diagnosticClient;
        _calibrationClient = calibrationClient;
        _sampleClient = sampleClient;
        _logger = logger;
    }

    [HttpGet("server-time")]
    [ProducesResponseType(typeof(SaisResultDto<DateTime>), StatusCodes.Status200OK)]
    public Task<ActionResult<SaisResultDto<DateTime>>> GetServerDateTime(CancellationToken cancellationToken) =>
        ExecuteAsync(
            ct => _timeClient.GetServerDateTimeAsync(ct),
            offset => offset.UtcDateTime,
            cancellationToken,
            nameof(GetServerDateTime));

    [HttpGet("stations/{stationId}")]
    [ProducesResponseType(typeof(SaisResultDto<StationInformationDto>), StatusCodes.Status200OK)]
    public Task<ActionResult<SaisResultDto<StationInformationDto>>> GetStationInformation(Guid stationId, CancellationToken cancellationToken) =>
        ExecuteAsync(
            ct => _stationClient.GetStationInformationAsync(stationId, ct),
            response => response.ToDto(),
            cancellationToken,
            nameof(GetStationInformation));

    [HttpPost("stations/host")]
    [ProducesResponseType(typeof(SaisResultDto), StatusCodes.Status200OK)]
    public Task<ActionResult<SaisResultDto>> UpdateStationHost([FromBody] StationHostUpdateRequestDto request, CancellationToken cancellationToken) =>
        ExecuteAsync(
            ct => _stationClient.UpdateStationHostAsync(request.ToRemote(), ct),
            cancellationToken,
            nameof(UpdateStationHost));

    [HttpGet("stations/{stationId}/channels")]
    [ProducesResponseType(typeof(SaisResultDto<IReadOnlyCollection<ChannelInformationDto>>), StatusCodes.Status200OK)]
    public Task<ActionResult<SaisResultDto<IReadOnlyCollection<ChannelInformationDto>>>> GetChannels(Guid stationId, CancellationToken cancellationToken) =>
        ExecuteCollectionAsync(
            ct => _channelClient.GetChannelsAsync(stationId, ct),
            response => response.ToDto(),
            cancellationToken,
            nameof(GetChannels));

    [HttpPut("channels")]
    [ProducesResponseType(typeof(SaisResultDto), StatusCodes.Status200OK)]
    public Task<ActionResult<SaisResultDto>> UpdateChannel([FromBody] ChannelUpdateRequestDto request, CancellationToken cancellationToken) =>
        ExecuteAsync(
            ct => _channelClient.UpdateChannelAsync(request.ToRemote(), ct),
            cancellationToken,
            nameof(UpdateChannel));

    [HttpGet("parameters")]
    [ProducesResponseType(typeof(SaisResultDto<IReadOnlyCollection<ParameterInformationDto>>), StatusCodes.Status200OK)]
    public Task<ActionResult<SaisResultDto<IReadOnlyCollection<ParameterInformationDto>>>> GetParameters(CancellationToken cancellationToken) =>
        ExecuteCollectionAsync(
            _generalInformationClient.GetParametersAsync,
            response => response.ToDto(),
            cancellationToken,
            nameof(GetParameters));

    [HttpGet("units")]
    [ProducesResponseType(typeof(SaisResultDto<IReadOnlyCollection<UnitInformationDto>>), StatusCodes.Status200OK)]
    public Task<ActionResult<SaisResultDto<IReadOnlyCollection<UnitInformationDto>>>> GetUnits(CancellationToken cancellationToken) =>
        ExecuteCollectionAsync(
            _generalInformationClient.GetUnitsAsync,
            response => response.ToDto(),
            cancellationToken,
            nameof(GetUnits));

    [HttpPost("measurements")]
    [ProducesResponseType(typeof(SaisResultDto<MeasurementDataDto>), StatusCodes.Status200OK)]
    public Task<ActionResult<SaisResultDto<MeasurementDataDto>>> SendMeasurement([FromBody] SendMeasurementRequestDto request, CancellationToken cancellationToken) =>
        ExecuteAsync(
            ct => _dataClient.SendMeasurementAsync(request.ToRemote(), ct),
            response => response.ToDto(),
            cancellationToken,
            nameof(SendMeasurement));

    [HttpGet("stations/{stationId}/measurements/last")]
    [ProducesResponseType(typeof(SaisResultDto<MeasurementDataDto>), StatusCodes.Status200OK)]
    public Task<ActionResult<SaisResultDto<MeasurementDataDto>>> GetLastMeasurement(Guid stationId, [FromQuery] int period, CancellationToken cancellationToken) =>
        ExecuteAsync(
            ct => _dataClient.GetLastMeasurementAsync(stationId, period, ct),
            response => response.ToDto(),
            cancellationToken,
            nameof(GetLastMeasurement));

    [HttpGet("stations/{stationId}/missing-dates")]
    [ProducesResponseType(typeof(SaisResultDto<MissingDataDto>), StatusCodes.Status200OK)]
    public Task<ActionResult<SaisResultDto<MissingDataDto>>> GetMissingDates(Guid stationId, CancellationToken cancellationToken) =>
        ExecuteAsync(
            ct => _dataClient.GetMissingDatesAsync(stationId, ct),
            response => response.ToDto(),
            cancellationToken,
            nameof(GetMissingDates));

    [HttpGet("stations/{stationId}/measurements")]
    [ProducesResponseType(typeof(SaisResultDto<IReadOnlyCollection<MeasurementDataDto>>), StatusCodes.Status200OK)]
    public Task<ActionResult<SaisResultDto<IReadOnlyCollection<MeasurementDataDto>>>> GetMeasurements(
        Guid stationId,
        [FromQuery] int period,
        [FromQuery] DateTime startDate,
        [FromQuery] DateTime endDate,
        CancellationToken cancellationToken) =>
        ExecuteCollectionAsync(
            ct => _dataClient.GetMeasurementsAsync(stationId, period, ToOffset(startDate), ToOffset(endDate), ct),
            response => response.ToDto(),
            cancellationToken,
            nameof(GetMeasurements));

    [HttpGet("data-statuses")]
    [ProducesResponseType(typeof(SaisResultDto<IReadOnlyCollection<DataStatusDto>>), StatusCodes.Status200OK)]
    public Task<ActionResult<SaisResultDto<IReadOnlyCollection<DataStatusDto>>>> GetDataStatuses(CancellationToken cancellationToken) =>
        ExecuteCollectionAsync(
            _generalInformationClient.GetDataStatusesAsync,
            response => response.ToDto(),
            cancellationToken,
            nameof(GetDataStatuses));

    [HttpGet("diagnostic-types")]
    [ProducesResponseType(typeof(SaisResultDto<IReadOnlyCollection<DiagnosticTypeDto>>), StatusCodes.Status200OK)]
    public Task<ActionResult<SaisResultDto<IReadOnlyCollection<DiagnosticTypeDto>>>> GetDiagnosticTypes(CancellationToken cancellationToken) =>
        ExecuteCollectionAsync(
            _diagnosticClient.GetDiagnosticTypesAsync,
            response => response.ToDto(),
            cancellationToken,
            nameof(GetDiagnosticTypes));

    [HttpPost("diagnostics")]
    [ProducesResponseType(typeof(SaisResultDto), StatusCodes.Status200OK)]
    public Task<ActionResult<SaisResultDto>> SendDiagnostic([FromBody] SendDiagnosticRequestDto request, CancellationToken cancellationToken) =>
        ExecuteAsync(
            ct => _diagnosticClient.SendDiagnosticAsync(request.ToRemote(), ct),
            cancellationToken,
            nameof(SendDiagnostic));

    [HttpPost("diagnostics/power-off")]
    [ProducesResponseType(typeof(SaisResultDto), StatusCodes.Status200OK)]
    public Task<ActionResult<SaisResultDto>> SendPowerOff([FromBody] PowerOffNotificationRequestDto request, CancellationToken cancellationToken) =>
        ExecuteAsync(
            ct => _diagnosticClient.SendPowerOffNotificationAsync(request.ToRemote(), ct),
            cancellationToken,
            nameof(SendPowerOff));

    [HttpPost("diagnostics/typed")]
    [ProducesResponseType(typeof(SaisResultDto), StatusCodes.Status200OK)]
    public Task<ActionResult<SaisResultDto>> SendDiagnosticWithType([FromBody] SendDiagnosticWithTypeRequestDto request, CancellationToken cancellationToken) =>
        ExecuteAsync(
            ct => _diagnosticClient.SendDiagnosticAsync(request.ToRemote(), ct),
            cancellationToken,
            nameof(SendDiagnosticWithType));

    [HttpPost("calibrations")]
    [ProducesResponseType(typeof(SaisResultDto), StatusCodes.Status200OK)]
    public Task<ActionResult<SaisResultDto>> SendCalibration([FromBody] SendCalibrationRequestDto request, CancellationToken cancellationToken) =>
        ExecuteAsync(
            ct => _calibrationClient.SendCalibrationAsync(request.ToRemote(), ct),
            cancellationToken,
            nameof(SendCalibration));

    [HttpGet("stations/{stationId}/calibrations")]
    [ProducesResponseType(typeof(SaisResultDto<IReadOnlyCollection<CalibrationRecordDto>>), StatusCodes.Status200OK)]
    public Task<ActionResult<SaisResultDto<IReadOnlyCollection<CalibrationRecordDto>>>> GetCalibrations(
        Guid stationId,
        [FromQuery] DateTime startDate,
        [FromQuery] DateTime endDate,
        CancellationToken cancellationToken) =>
        ExecuteCollectionAsync(
            ct => _calibrationClient.GetCalibrationsAsync(stationId, ToOffset(startDate), ToOffset(endDate), ct),
            response => response.ToDto(),
            cancellationToken,
            nameof(GetCalibrations));

    [HttpPost("samples/start")]
    [ProducesResponseType(typeof(SaisResultDto), StatusCodes.Status200OK)]
    public Task<ActionResult<SaisResultDto>> NotifySampleStart([FromBody] SampleRequestStartDto request, CancellationToken cancellationToken) =>
        ExecuteAsync(
            ct => _sampleClient.NotifySampleStartAsync(request.ToRemote(), ct),
            cancellationToken,
            nameof(NotifySampleStart));

    [HttpPost("samples/limit")]
    [ProducesResponseType(typeof(SaisResultDto<string>), StatusCodes.Status200OK)]
    public Task<ActionResult<SaisResultDto<string>>> NotifySampleLimit([FromBody] SampleLimitRequestDto request, CancellationToken cancellationToken) =>
        ExecuteAsync(
            ct => _sampleClient.NotifySampleStartForLimitAsync(request.ToRemote(), ct),
            result => result,
            cancellationToken,
            nameof(NotifySampleLimit));

    [HttpPost("samples/complete")]
    [ProducesResponseType(typeof(SaisResultDto), StatusCodes.Status200OK)]
    public Task<ActionResult<SaisResultDto>> CompleteSample([FromBody] SampleStatusUpdateRequestDto request, CancellationToken cancellationToken) =>
        ExecuteAsync(
            ct => _sampleClient.CompleteSampleAsync(request.ToRemote(), ct),
            cancellationToken,
            nameof(CompleteSample));

    [HttpPost("samples/error")]
    [ProducesResponseType(typeof(SaisResultDto), StatusCodes.Status200OK)]
    public Task<ActionResult<SaisResultDto>> ReportSampleError([FromBody] SampleStatusUpdateRequestDto request, CancellationToken cancellationToken) =>
        ExecuteAsync(
            ct => _sampleClient.ReportSampleErrorAsync(request.ToRemote(), ct),
            cancellationToken,
            nameof(ReportSampleError));

    private async Task<ActionResult<SaisResultDto<TResult>>> ExecuteAsync<TSource, TResult>(
        Func<CancellationToken, Task<TSource>> action,
        Func<TSource, TResult> mapper,
        CancellationToken cancellationToken,
        string operationName)
    {
        try
        {
            var source = await action(cancellationToken);
            var payload = mapper(source);
            return Ok(SaisResultDto<TResult>.Success(payload));
        }
        catch (SaisApiException ex)
        {
            _logger.LogWarning(ex, "SAİS operation {Operation} failed due to remote API error.", operationName);
            return StatusCode(StatusCodes.Status502BadGateway, SaisResultDto<TResult>.Failure(ex.Message));
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "SAİS operation {Operation} failed.", operationName);
            return StatusCode(StatusCodes.Status500InternalServerError, SaisResultDto<TResult>.Failure("İşlem sırasında beklenmeyen bir hata oluştu."));
        }
    }

    private Task<ActionResult<SaisResultDto<IReadOnlyCollection<TResult>>>> ExecuteCollectionAsync<TSource, TResult>(
        Func<CancellationToken, Task<IReadOnlyCollection<TSource>>> action,
        Func<TSource, TResult> mapper,
        CancellationToken cancellationToken,
        string operationName)
    {
        return ExecuteAsync<IReadOnlyCollection<TSource>, IReadOnlyCollection<TResult>>(
            action,
            source => source.Select(mapper).ToArray(),
            cancellationToken,
            operationName);
    }

    private static DateTimeOffset ToOffset(DateTime value) => value.Kind switch
    {
        DateTimeKind.Unspecified => new DateTimeOffset(value, TimeZoneInfo.Local.GetUtcOffset(value)),
        DateTimeKind.Local => new DateTimeOffset(value),
        DateTimeKind.Utc => new DateTimeOffset(value, TimeSpan.Zero),
        _ => new DateTimeOffset(value)
    };

    private async Task<ActionResult<SaisResultDto>> ExecuteAsync(
        Func<CancellationToken, Task> action,
        CancellationToken cancellationToken,
        string operationName)
    {
        try
        {
            await action(cancellationToken);
            return Ok(SaisResultDto.Success());
        }
        catch (SaisApiException ex)
        {
            _logger.LogWarning(ex, "SAİS operation {Operation} failed due to remote API error.", operationName);
            return StatusCode(StatusCodes.Status502BadGateway, SaisResultDto.Failure(ex.Message));
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "SAİS operation {Operation} failed.", operationName);
            return StatusCode(StatusCodes.Status500InternalServerError, SaisResultDto.Failure("İşlem sırasında beklenmeyen bir hata oluştu."));
        }
    }
}
