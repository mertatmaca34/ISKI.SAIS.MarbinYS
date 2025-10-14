using System.Text.Json.Serialization;

namespace Infrastructure.Remote.SAIS.Models;

public sealed record SaisResultEnvelope<T>
{
    [JsonPropertyName("result")]
    public bool Result { get; init; }

    [JsonPropertyName("message")]
    public string? Message { get; init; }

    [JsonPropertyName("objects")]
    public T? Objects { get; init; }
}
