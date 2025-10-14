using System.Text.Json.Serialization;

namespace Infrastructure.Remote.SAIS.DTOs.Responses;

public sealed class DataStatusResponse
{
    [JsonPropertyName("StatusCode")]
    public int StatusCode { get; init; }

    [JsonPropertyName("StatusName")]
    public string? StatusName { get; init; }

    [JsonPropertyName("StatusDescription")]
    public string? StatusDescription { get; init; }

    [JsonPropertyName("IsValid")]
    public bool IsValid { get; init; }
}
