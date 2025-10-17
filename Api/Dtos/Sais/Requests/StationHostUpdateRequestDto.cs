using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Api.Dtos.Sais.Requests;

public sealed class StationHostUpdateRequestDto
{
    [JsonPropertyName("StationId")]
    [Required]
    public Guid StationId { get; set; }

    [JsonPropertyName("ConnectionUser")]
    [Required]
    public string ConnectionUser { get; set; } = string.Empty;

    [JsonPropertyName("ConnectionPassword")]
    [Required]
    public string ConnectionPassword { get; set; } = string.Empty;

    [JsonPropertyName("ConnectionDomainAddress")]
    [Required]
    public string ConnectionDomainAddress { get; set; } = string.Empty;

    [JsonPropertyName("ConnectionPort")]
    [Required]
    public int? ConnectionPort { get; set; }
}
