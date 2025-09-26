using System;
using System.Text.Json.Serialization;

namespace WinUI.Models;

public class ExternalSendDataDto
{
    [JsonPropertyName("Stationid")]
    public Guid StationId { get; set; }

    [JsonPropertyName("Readtime")]
    public DateTime ReadTime { get; set; }

    [JsonPropertyName("SoftwareVersion")]
    public string? SoftwareVersion { get; set; }

    [JsonPropertyName("AkisHizi")]
    public double? AkisHizi { get; set; }

    [JsonPropertyName("AKM")]
    public double? AKM { get; set; }

    [JsonPropertyName("CozunmusOksijen")]
    public double? CozunmusOksijen { get; set; }

    [JsonPropertyName("Debi")]
    public double? Debi { get; set; }

    [JsonPropertyName("DesarjDebi")]
    public double? DesarjDebi { get; set; }

    [JsonPropertyName("HariciDebi")]
    public double? HariciDebi { get; set; }

    [JsonPropertyName("HariciDebi2")]
    public double? HariciDebi2 { get; set; }

    [JsonPropertyName("KOi")]
    public double? KOi { get; set; }

    [JsonPropertyName("pH")]
    public double? pH { get; set; }

    [JsonPropertyName("Sicaklik")]
    public double? Sicaklik { get; set; }

    [JsonPropertyName("Iletkenlik")]
    public double? Iletkenlik { get; set; }

    [JsonPropertyName("Period")]
    public int? Period { get; set; }

    [JsonPropertyName("AkisHizi_Status")]
    public int? AkisHiziStatus { get; set; }

    [JsonPropertyName("AKM_Status")]
    public int? AKMStatus { get; set; }

    [JsonPropertyName("CozunmusOksijen_Status")]
    public int? CozunmusOksijenStatus { get; set; }

    [JsonPropertyName("Debi_Status")]
    public int? DebiStatus { get; set; }

    [JsonPropertyName("DesarjDebi_Status")]
    public int? DesarjDebiStatus { get; set; }

    [JsonPropertyName("HariciDebi_Status")]
    public int? HariciDebiStatus { get; set; }

    [JsonPropertyName("HariciDebi2_Status")]
    public int? HariciDebi2Status { get; set; }

    [JsonPropertyName("KOi_Status")]
    public int? KOiStatus { get; set; }

    [JsonPropertyName("pH_Status")]
    public int? pHStatus { get; set; }

    [JsonPropertyName("Sicaklik_Status")]
    public int? SicaklikStatus { get; set; }

    [JsonPropertyName("Iletkenlik_Status")]
    public string? IletkenlikStatus { get; set; }

    [JsonPropertyName("IsSent")]
    public bool? IsSent { get; set; }

    [JsonPropertyName("SaatlikYikamaGecersiz")]
    public bool? SaatlikYikamaGecersiz { get; set; }

    [JsonPropertyName("HaftalikYikamaGecersiz")]
    public bool? HaftalikYikamaGecersiz { get; set; }

    [JsonPropertyName("KalibrasyonGecersiz")]
    public bool? KalibrasyonGecersiz { get; set; }

    [JsonPropertyName("AkisHiziGecersiz")]
    public bool? AkisHiziGecersiz { get; set; }

    [JsonPropertyName("GecersizDebi")]
    public bool? GecersizDebi { get; set; }

    [JsonPropertyName("TekrarVeriGecersiz")]
    public bool? TekrarVeriGecersiz { get; set; }

    [JsonPropertyName("GecersizOlcumBirimi")]
    public bool? GecersizOlcumBirimi { get; set; }
}

public class ExternalCalibrationRecordDto
{
    [JsonPropertyName("CalibrationDate")]
    public DateTime CalibrationDate { get; set; }

    [JsonPropertyName("DBColumnName")]
    public string? DBColumnName { get; set; }

    [JsonPropertyName("ZeroRef")]
    public double? ZeroRef { get; set; }

    [JsonPropertyName("ZeroMeas")]
    public double? ZeroMeas { get; set; }

    [JsonPropertyName("ZeroDiff")]
    public double? ZeroDiff { get; set; }

    [JsonPropertyName("ZeroSTD")]
    public double? ZeroStd { get; set; }

    [JsonPropertyName("SpanRef")]
    public double? SpanRef { get; set; }

    [JsonPropertyName("SpanMeas")]
    public double? SpanMeas { get; set; }

    [JsonPropertyName("SpanDiff")]
    public double? SpanDiff { get; set; }

    [JsonPropertyName("SpanSTD")]
    public double? SpanStd { get; set; }

    [JsonPropertyName("ResultFactor")]
    public double? ResultFactor { get; set; }

    [JsonPropertyName("ResultZero")]
    public bool? ResultZero { get; set; }

    [JsonPropertyName("ResultSpan")]
    public bool? ResultSpan { get; set; }

    [JsonPropertyName("Result")]
    public bool? Result { get; set; }
}
