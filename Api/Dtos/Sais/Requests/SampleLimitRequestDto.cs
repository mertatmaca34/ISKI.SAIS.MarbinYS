using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Api.Dtos.Sais.Requests;

public sealed class SampleLimitRequestDto
{
    [JsonPropertyName("StationId")]
    [Required]
    public Guid StationId { get; set; }

    [JsonPropertyName("Parameter")]
    [Required]
    public string Parameter { get; set; } = string.Empty;
}
