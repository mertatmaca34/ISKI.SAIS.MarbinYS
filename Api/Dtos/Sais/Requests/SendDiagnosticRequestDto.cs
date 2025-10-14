using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Api.Dtos.Sais.Requests;

public sealed class SendDiagnosticRequestDto
{
    [JsonPropertyName("stationId")]
    [Required]
    public Guid StationId { get; set; }

    [JsonPropertyName("details")]
    [Required]
    public string Details { get; set; } = string.Empty;

    [JsonPropertyName("startDate")]
    [Required]
    public DateTime StartDate { get; set; }
}
