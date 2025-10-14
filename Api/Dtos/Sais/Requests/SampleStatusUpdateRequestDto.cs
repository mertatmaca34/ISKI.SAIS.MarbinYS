using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Api.Dtos.Sais.Requests;

public sealed class SampleStatusUpdateRequestDto
{
    [JsonPropertyName("StationId")]
    [Required]
    public Guid StationId { get; set; }

    [JsonPropertyName("SampleCode")]
    [Required]
    public string SampleCode { get; set; } = string.Empty;
}
