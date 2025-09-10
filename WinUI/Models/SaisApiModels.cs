using System;
using System.Collections.Generic;

namespace WinUI.Models;

public class ChannelInfoDto
{
    public string Brand { get; set; } = string.Empty;
    public string BrandModel { get; set; } = string.Empty;
    public string FullName { get; set; } = string.Empty;
    public string Parameter { get; set; } = string.Empty;
    public string ParameterText { get; set; } = string.Empty;
    public Guid Unit { get; set; }
    public string UnitText { get; set; } = string.Empty;
    public bool IsActive { get; set; }
    public double ChannelMinValue { get; set; }
    public double ChannelMaxValue { get; set; }
    public short ChannelNumber { get; set; }
    public double CalibrationFormulaA { get; set; }
    public double CalibrationFormulaB { get; set; }
    public string SerialNumber { get; set; } = string.Empty;
}

public class UpdateChannelInformationRequest
{
    public Guid id { get; set; }
    public Guid Unit { get; set; }
    public bool IsActive { get; set; }
    public double ChannelMinValue { get; set; }
    public double ChannelMaxValue { get; set; }
    public short ChannelNumber { get; set; }
    public double CalibrationFormulaA { get; set; }
    public double CalibrationFormulaB { get; set; }
}

public class ParameterDto
{
    public string Parameter { get; set; } = string.Empty;
    public string ParameterText { get; set; } = string.Empty;
    public int MonitorType { get; set; }
    public string MonitorTypeText { get; set; } = string.Empty;
}

public class UnitDto
{
    public Guid id { get; set; }
    public string Name { get; set; } = string.Empty;
}

public class ApiDataResultDto
{
    public int Period { get; set; }
    public DateTime ReadTime { get; set; }
    public double? AKM { get; set; }
    public int? AKM_Status { get; set; }
    public double? Debi { get; set; }
    public int? Debi_Status { get; set; }
    public double? KOi { get; set; }
    public int? KOi_Status { get; set; }
    public double? pH { get; set; }
    public int? pH_Status { get; set; }
    public double? CozunmusOksijen { get; set; }
    public int? CozunmusOksijen_Status { get; set; }
    public double? AkisHizi { get; set; }
    public int? AkisHizi_Status { get; set; }
    public double? Sicaklik { get; set; }
    public int? Sicaklik_Status { get; set; }
}

public class MissingDatesDto
{
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public List<DateTime> MissingDates { get; set; } = new();
}

public class DataStatusDto
{
    public int StatusCode { get; set; }
    public string StatusName { get; set; } = string.Empty;
    public string StatusDescription { get; set; } = string.Empty;
    public bool IsValid { get; set; }
}

public class DiagnosticTypeDto
{
    public int DiagnosticTypeNo { get; set; }
    public string DiagnosticTypeName { get; set; } = string.Empty;
    public int DiagnosticLevel { get; set; }
    public string DiagnosticLevel_Title { get; set; } = string.Empty;
}

public class DiagnosticRequest
{
    public Guid StationId { get; set; }
    public string Details { get; set; } = string.Empty;
    public DateTime StartDate { get; set; }
}

public class PowerOffTimeRequest
{
    public Guid StationId { get; set; }
    public DateTime StartTime { get; set; }
    public DateTime EndTime { get; set; }
}

public class DiagnosticWithTypeRequest
{
    public Guid StationId { get; set; }
    public string Details { get; set; } = string.Empty;
    public int DiagnosticTypeNo { get; set; }
    public DateTime StartDate { get; set; }
}

public class CalibrationRequest
{
    public DateTime CalibrationDate { get; set; }
    public Guid StationId { get; set; }
    public string DBColumnName { get; set; } = string.Empty;
    public double ZeroRef { get; set; }
    public double ZeroMeas { get; set; }
    public double ZeroDiff { get; set; }
    public double ZeroSTD { get; set; }
    public double SpanRef { get; set; }
    public double SpanMeas { get; set; }
    public double SpanDiff { get; set; }
    public double SpanSTD { get; set; }
    public double ResultFactor { get; set; }
    public bool ResultZero { get; set; }
    public bool ResultSpan { get; set; }
}

public class CalibrationRecordDto : CalibrationRequest
{
    public bool Result { get; set; }
}

public class SampleRequestStart
{
    public Guid StationId { get; set; }
    public string SampleCode { get; set; } = string.Empty;
}

public class SampleRequestLimitOver
{
    public Guid StationId { get; set; }
    public string Parameter { get; set; } = string.Empty;
}

public class SampleRequestComplete
{
    public Guid StationId { get; set; }
    public string SampleCode { get; set; } = string.Empty;
}

public class SampleRequestError
{
    public Guid StationId { get; set; }
    public string SampleCode { get; set; } = string.Empty;
}

public class SendHostChangedRequest
{
    public Guid StationId { get; set; }
    public string ConnectionUser { get; set; } = string.Empty;
    public string ConnectionPassword { get; set; } = string.Empty;
    public string ConnectionDomainAddress { get; set; } = string.Empty;
    public string ConnectionPort { get; set; } = string.Empty;
}
