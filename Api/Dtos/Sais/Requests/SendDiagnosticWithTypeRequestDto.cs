using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Api.Dtos.Sais.Requests;

public sealed class SendDiagnosticWithTypeRequestDto
{
    [JsonPropertyName("stationId")]
    [Required]
    public Guid StationId { get; set; }

    [JsonPropertyName("details")]
    [Required]
    public string Details { get; set; } = string.Empty;

    [JsonPropertyName("DiagnosticTypeNo")]
    [Required]
    public int DiagnosticTypeNo { get; set; }

    [JsonPropertyName("startDate")]
    [Required]
    public DateTime StartDate { get; set; }
}
