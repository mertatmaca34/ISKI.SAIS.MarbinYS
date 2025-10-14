using System.Text.Json.Serialization;

namespace Infrastructure.Remote.SAIS.DTOs.Responses;

public sealed class CalibrationRecordResponse
{
    [JsonPropertyName("StationId")]
    public Guid StationId { get; init; }

    [JsonPropertyName("DBColumnName")]
    public string? ParameterColumnName { get; init; }

    [JsonPropertyName("CalibrationDate")]
    public DateTimeOffset CalibrationDate { get; init; }

    [JsonPropertyName("ZeroRef")]
    public double? ZeroRef { get; init; }

    [JsonPropertyName("ZeroMeas")]
    public double? ZeroMeasurement { get; init; }

    [JsonPropertyName("ZeroDiff")]
    public double? ZeroDifference { get; init; }

    [JsonPropertyName("ZeroSTD")]
    public double? ZeroStandardDeviation { get; init; }

    [JsonPropertyName("SpanRef")]
    public double? SpanRef { get; init; }

    [JsonPropertyName("SpanMeas")]
    public double? SpanMeasurement { get; init; }

    [JsonPropertyName("SpanDiff")]
    public double? SpanDifference { get; init; }

    [JsonPropertyName("SpanSTD")]
    public double? SpanStandardDeviation { get; init; }

    [JsonPropertyName("ResultFactor")]
    public double? ResultFactor { get; init; }

    [JsonPropertyName("ResultZero")]
    public bool ResultZero { get; init; }

    [JsonPropertyName("ResultSpan")]
    public bool ResultSpan { get; init; }

    [JsonPropertyName("Result")]
    public bool? Result { get; init; }
}
