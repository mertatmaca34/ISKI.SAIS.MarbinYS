using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Api.Dtos.Sais.Requests;

public sealed class SendCalibrationRequestDto
{
    [JsonPropertyName("CalibrationDate")]
    [Required]
    public DateTime CalibrationDate { get; set; }

    [JsonPropertyName("StationId")]
    [Required]
    public Guid StationId { get; set; }

    [JsonPropertyName("DBColumnName")]
    [Required]
    public string ParameterColumnName { get; set; } = string.Empty;

    [JsonPropertyName("ZeroRef")]
    public double? ZeroRef { get; set; }

    [JsonPropertyName("ZeroMeas")]
    public double? ZeroMeasurement { get; set; }

    [JsonPropertyName("ZeroDiff")]
    public double? ZeroDifference { get; set; }

    [JsonPropertyName("ZeroSTD")]
    public double? ZeroStandardDeviation { get; set; }

    [JsonPropertyName("SpanRef")]
    public double? SpanRef { get; set; }

    [JsonPropertyName("SpanMeas")]
    public double? SpanMeasurement { get; set; }

    [JsonPropertyName("SpanDiff")]
    public double? SpanDifference { get; set; }

    [JsonPropertyName("SpanSTD")]
    public double? SpanStandardDeviation { get; set; }

    [JsonPropertyName("ResultFactor")]
    public double? ResultFactor { get; set; }

    [JsonPropertyName("ResultZero")]
    public bool ResultZero { get; set; }

    [JsonPropertyName("ResultSpan")]
    public bool ResultSpan { get; set; }
}
