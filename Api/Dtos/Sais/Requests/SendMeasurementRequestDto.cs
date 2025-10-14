using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Api.Dtos.Sais.Requests;

public sealed class SendMeasurementRequestDto
{
    [JsonPropertyName("Stationid")]
    [Required]
    public Guid StationId { get; set; }

    [JsonPropertyName("Readtime")]
    [Required]
    public DateTime ReadTime { get; set; }

    [JsonPropertyName("SoftwareVersion")]
    public string SoftwareVersion { get; set; } = string.Empty;

    [JsonPropertyName("Period")]
    public int Period { get; set; }

    [JsonPropertyName("AkisHizi")]
    public double? FlowVelocity { get; set; }

    [JsonPropertyName("AkisHizi_Status")]
    public int? FlowVelocityStatus { get; set; }

    [JsonPropertyName("AKM")]
    public double? Akm { get; set; }

    [JsonPropertyName("AKM_Status")]
    public int? AkmStatus { get; set; }

    [JsonPropertyName("CozunmusOksijen")]
    public double? DissolvedOxygen { get; set; }

    [JsonPropertyName("CozunmusOksijen_Status")]
    public int? DissolvedOxygenStatus { get; set; }

    [JsonPropertyName("Debi")]
    public double? Debi { get; set; }

    [JsonPropertyName("Debi_Status")]
    public int? DebiStatus { get; set; }

    [JsonPropertyName("KOi")]
    public double? Koi { get; set; }

    [JsonPropertyName("KOi_Status")]
    public int? KoiStatus { get; set; }

    [JsonPropertyName("pH")]
    public double? Ph { get; set; }

    [JsonPropertyName("pH_Status")]
    public int? PhStatus { get; set; }

    [JsonPropertyName("Sicaklik")]
    public double? Temperature { get; set; }

    [JsonPropertyName("Sicaklik_Status")]
    public int? TemperatureStatus { get; set; }
}
