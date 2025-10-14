using System.Text.Json.Serialization;

namespace Infrastructure.Remote.SAIS.DTOs.Requests;

public sealed class SendMeasurementRequest
{
    [JsonPropertyName("Stationid")]
    public Guid StationId { get; init; }

    [JsonPropertyName("Readtime")]
    public DateTimeOffset ReadTime { get; init; }

    [JsonPropertyName("SoftwareVersion")]
    public string SoftwareVersion { get; init; } = string.Empty;

    [JsonPropertyName("Period")]
    public int Period { get; init; }

    [JsonPropertyName("AkisHizi")]
    public double? FlowVelocity { get; init; }

    [JsonPropertyName("AkisHizi_Status")]
    public int? FlowVelocityStatus { get; init; }

    [JsonPropertyName("AKM")]
    public double? Akm { get; init; }

    [JsonPropertyName("AKM_Status")]
    public int? AkmStatus { get; init; }

    [JsonPropertyName("CozunmusOksijen")]
    public double? DissolvedOxygen { get; init; }

    [JsonPropertyName("CozunmusOksijen_Status")]
    public int? DissolvedOxygenStatus { get; init; }

    [JsonPropertyName("Debi")]
    public double? Debi { get; init; }

    [JsonPropertyName("Debi_Status")]
    public int? DebiStatus { get; init; }

    [JsonPropertyName("KOi")]
    public double? Koi { get; init; }

    [JsonPropertyName("KOi_Status")]
    public int? KoiStatus { get; init; }

    [JsonPropertyName("pH")]
    public double? Ph { get; init; }

    [JsonPropertyName("pH_Status")]
    public int? PhStatus { get; init; }

    [JsonPropertyName("Sicaklik")]
    public double? Temperature { get; init; }

    [JsonPropertyName("Sicaklik_Status")]
    public int? TemperatureStatus { get; init; }
}
