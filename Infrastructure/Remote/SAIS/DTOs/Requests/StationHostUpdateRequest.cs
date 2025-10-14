using System.Text.Json.Serialization;

namespace Infrastructure.Remote.SAIS.DTOs.Requests;

public sealed class StationHostUpdateRequest
{
    [JsonPropertyName("StationId")]
    public Guid StationId { get; init; }

    [JsonPropertyName("ConnectionUser")]
    public string ConnectionUser { get; init; } = string.Empty;

    [JsonPropertyName("ConnectionPassword")]
    public string ConnectionPassword { get; init; } = string.Empty;

    [JsonPropertyName("ConnectionDomainAddress")]
    public string ConnectionDomainAddress { get; init; } = string.Empty;

    [JsonPropertyName("ConnectionPort")]
    public string ConnectionPort { get; init; } = string.Empty;
}
