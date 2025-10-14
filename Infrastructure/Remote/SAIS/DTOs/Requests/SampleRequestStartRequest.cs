using System.Text.Json.Serialization;

namespace Infrastructure.Remote.SAIS.DTOs.Requests;

public sealed class SampleRequestStartRequest
{
    [JsonPropertyName("StationId")]
    public Guid StationId { get; init; }

    [JsonPropertyName("SampleCode")]
    public string SampleCode { get; init; } = string.Empty;
}
