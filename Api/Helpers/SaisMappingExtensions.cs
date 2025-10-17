using System;
using System.Linq;
using Api.Dtos.Sais.Requests;
using Api.Dtos.Sais.Responses;
using Infrastructure.Remote.SAIS.DTOs.Requests;
using Infrastructure.Remote.SAIS.DTOs.Responses;

namespace Api.Helpers;

public static class SaisMappingExtensions
{
    public static StationInformationDto ToDto(this StationInformationResponse response)
    {
        ArgumentNullException.ThrowIfNull(response);

        return new StationInformationDto
        {
            StationId = response.StationId,
            Code = response.Code,
            Name = response.Name,
            DataPeriodMinute = response.DataPeriodMinute <= short.MaxValue
                ? (short?)response.DataPeriodMinute
                : null,
            LastDataDate = response.LastDataDate,
            ConnectionDomainAddress = response.ConnectionDomainAddress,
            ConnectionPort = response.ConnectionPort,
            ConnectionUser = response.ConnectionUser,
            ConnectionPassword = response.ConnectionPassword,
            Company = response.Company,
            BirthDate = response.BirthDate,
            SetupDate = response.SetupDate,
            Address = response.Address,
            Software = response.Software
        };
    }

    public static ChannelInformationDto ToDto(this ChannelInformationResponse response)
    {
        ArgumentNullException.ThrowIfNull(response);

        return new ChannelInformationDto
        {
            Id  = response.Id,
            Brand = response.Brand,
            BrandModel = response.BrandModel,
            FullName = response.FullName,
            Parameter = response.Parameter,
            ParameterText = response.ParameterText,
            Unit = response.Unit,
            UnitText = response.UnitText,
            IsActive = response.IsActive,
            ChannelMinValue = response.ChannelMinValue,
            ChannelMaxValue = response.ChannelMaxValue,
            ChannelNumber = response.ChannelNumber,
            CalibrationFormulaA = response.CalibrationFormulaA,
            CalibrationFormulaB = response.CalibrationFormulaB,
            SerialNumber = response.SerialNumber
        };
    }

    public static ParameterInformationDto ToDto(this ParameterInformationResponse response)
    {
        ArgumentNullException.ThrowIfNull(response);

        return new ParameterInformationDto
        {
            Parameter = response.Parameter,
            ParameterText = response.ParameterText,
            MonitorType = response.MonitorType,
            MonitorTypeText = response.MonitorTypeText
        };
    }

    public static UnitInformationDto ToDto(this UnitInformationResponse response)
    {
        ArgumentNullException.ThrowIfNull(response);

        return new UnitInformationDto
        {
            Id = response.Id,
            Name = response.Name
        };
    }

    public static MeasurementDataDto ToDto(this MeasurementDataResponse response)
    {
        ArgumentNullException.ThrowIfNull(response);

        return new MeasurementDataDto
        {
            Period = response.Period,
            ReadTime = response.ReadTime.UtcDateTime,
            Akm = response.Akm,
            AkmStatus = response.AkmStatus,
            Debi = response.Debi,
            DebiStatus = response.DebiStatus,
            Koi = response.Koi,
            KoiStatus = response.KoiStatus,
            Ph = response.Ph,
            PhStatus = response.PhStatus,
            FlowVelocity = response.FlowVelocity,
            FlowVelocityStatus = response.FlowVelocityStatus,
            DissolvedOxygen = response.DissolvedOxygen,
            DissolvedOxygenStatus = response.DissolvedOxygenStatus,
            Temperature = response.Temperature,
            TemperatureStatus = response.TemperatureStatus
        };
    }

    public static MissingDataDto ToDto(this MissingDataResponse response)
    {
        ArgumentNullException.ThrowIfNull(response);

        return new MissingDataDto
        {
            StartDate = response.StartDate.UtcDateTime,
            EndDate = response.EndDate.UtcDateTime,
            MissingDates = response.MissingDates
                .Select(x => x.UtcDateTime)
                .ToArray()
        };
    }

    public static DataStatusDto ToDto(this DataStatusResponse response)
    {
        ArgumentNullException.ThrowIfNull(response);

        return new DataStatusDto
        {
            StatusCode = response.StatusCode,
            StatusName = response.StatusName,
            StatusDescription = response.StatusDescription,
            IsValid = response.IsValid
        };
    }

    public static DiagnosticTypeDto ToDto(this DiagnosticTypeResponse response)
    {
        ArgumentNullException.ThrowIfNull(response);

        return new DiagnosticTypeDto
        {
            DiagnosticTypeNo = response.DiagnosticTypeNo,
            DiagnosticTypeName = response.DiagnosticTypeName,
            DiagnosticLevel = response.DiagnosticLevel,
            DiagnosticLevelTitle = response.DiagnosticLevelTitle
        };
    }

    public static CalibrationRecordDto ToDto(this CalibrationRecordResponse response)
    {
        ArgumentNullException.ThrowIfNull(response);

        return new CalibrationRecordDto
        {
            StationId = response.StationId,
            ParameterColumnName = response.ParameterColumnName,
            CalibrationDate = response.CalibrationDate.UtcDateTime,
            ZeroRef = response.ZeroRef,
            ZeroMeasurement = response.ZeroMeasurement,
            ZeroDifference = response.ZeroDifference,
            ZeroStandardDeviation = response.ZeroStandardDeviation,
            SpanRef = response.SpanRef,
            SpanMeasurement = response.SpanMeasurement,
            SpanDifference = response.SpanDifference,
            SpanStandardDeviation = response.SpanStandardDeviation,
            ResultFactor = response.ResultFactor,
            ResultZero = response.ResultZero,
            ResultSpan = response.ResultSpan,
            Result = response.Result
        };
    }

    public static StationHostUpdateRequest ToRemote(this StationHostUpdateRequestDto request)
    {
        ArgumentNullException.ThrowIfNull(request);

        return new StationHostUpdateRequest
        {
            StationId = request.StationId,
            ConnectionUser = request.ConnectionUser,
            ConnectionPassword = request.ConnectionPassword,
            ConnectionDomainAddress = request.ConnectionDomainAddress,
            ConnectionPort = request.ConnectionPort
        };
    }

    public static ChannelUpdateRequest ToRemote(this ChannelUpdateRequestDto request)
    {
        ArgumentNullException.ThrowIfNull(request);

        return new ChannelUpdateRequest
        {
            Id = request.Id,
            Unit = request.Unit,
            IsActive = request.IsActive,
            ChannelMinValue = request.ChannelMinValue,
            ChannelMaxValue = request.ChannelMaxValue,
            ChannelNumber = request.ChannelNumber,
            CalibrationFormulaA = request.CalibrationFormulaA,
            CalibrationFormulaB = request.CalibrationFormulaB
        };
    }

    public static SendMeasurementRequest ToRemote(this SendMeasurementRequestDto request)
    {
        ArgumentNullException.ThrowIfNull(request);

        return new SendMeasurementRequest
        {
            StationId = request.StationId,
            ReadTime = request.ReadTime.ToOffset(),
            SoftwareVersion = request.SoftwareVersion,
            Period = request.Period,
            FlowVelocity = request.FlowVelocity,
            FlowVelocityStatus = request.FlowVelocityStatus,
            Akm = request.Akm,
            AkmStatus = request.AkmStatus,
            DissolvedOxygen = request.DissolvedOxygen,
            DissolvedOxygenStatus = request.DissolvedOxygenStatus,
            Debi = request.Debi,
            DebiStatus = request.DebiStatus,
            Koi = request.Koi,
            KoiStatus = request.KoiStatus,
            Ph = request.Ph,
            PhStatus = request.PhStatus,
            Temperature = request.Temperature,
            TemperatureStatus = request.TemperatureStatus
        };
    }

    public static SendDiagnosticRequest ToRemote(this SendDiagnosticRequestDto request)
    {
        ArgumentNullException.ThrowIfNull(request);

        return new SendDiagnosticRequest
        {
            StationId = request.StationId,
            Details = request.Details,
            StartDate = request.StartDate.ToOffset()
        };
    }

    public static SendDiagnosticWithTypeRequest ToRemote(this SendDiagnosticWithTypeRequestDto request)
    {
        ArgumentNullException.ThrowIfNull(request);

        return new SendDiagnosticWithTypeRequest
        {
            StationId = request.StationId,
            Details = request.Details,
            DiagnosticTypeNo = request.DiagnosticTypeNo,
            StartDate = request.StartDate.ToOffset()
        };
    }

    public static PowerOffNotificationRequest ToRemote(this PowerOffNotificationRequestDto request)
    {
        ArgumentNullException.ThrowIfNull(request);

        return new PowerOffNotificationRequest
        {
            StationId = request.StationId,
            StartTime = request.StartTime.ToOffset(),
            EndTime = request.EndTime.ToOffset()
        };
    }

    public static SendCalibrationRequest ToRemote(this SendCalibrationRequestDto request)
    {
        ArgumentNullException.ThrowIfNull(request);

        return new SendCalibrationRequest
        {
            CalibrationDate = request.CalibrationDate.ToOffset(),
            StationId = request.StationId,
            ParameterColumnName = request.ParameterColumnName,
            ZeroRef = request.ZeroRef,
            ZeroMeasurement = request.ZeroMeasurement,
            ZeroDifference = request.ZeroDifference,
            ZeroStandardDeviation = request.ZeroStandardDeviation,
            SpanRef = request.SpanRef,
            SpanMeasurement = request.SpanMeasurement,
            SpanDifference = request.SpanDifference,
            SpanStandardDeviation = request.SpanStandardDeviation,
            ResultFactor = request.ResultFactor,
            ResultZero = request.ResultZero,
            ResultSpan = request.ResultSpan
        };
    }

    public static SampleRequestStartRequest ToRemote(this SampleRequestStartDto request)
    {
        ArgumentNullException.ThrowIfNull(request);

        return new SampleRequestStartRequest
        {
            StationId = request.StationId,
            SampleCode = request.SampleCode
        };
    }

    public static SampleLimitRequest ToRemote(this SampleLimitRequestDto request)
    {
        ArgumentNullException.ThrowIfNull(request);

        return new SampleLimitRequest
        {
            StationId = request.StationId,
            Parameter = request.Parameter
        };
    }

    public static SampleStatusUpdateRequest ToRemote(this SampleStatusUpdateRequestDto request)
    {
        ArgumentNullException.ThrowIfNull(request);

        return new SampleStatusUpdateRequest
        {
            StationId = request.StationId,
            SampleCode = request.SampleCode
        };
    }

    private static DateTimeOffset ToOffset(this DateTime value)
    {
        return value.Kind switch
        {
            DateTimeKind.Unspecified => new DateTimeOffset(value, TimeZoneInfo.Local.GetUtcOffset(value)),
            DateTimeKind.Local => new DateTimeOffset(value),
            DateTimeKind.Utc => new DateTimeOffset(value, TimeSpan.Zero),
            _ => new DateTimeOffset(value)
        };
    }
}
