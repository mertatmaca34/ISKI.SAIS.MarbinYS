using System.Text.Json.Serialization;

namespace Api.Dtos.Sais.Responses;

public sealed class DataStatusDto
{
    [JsonPropertyName("StatusCode")]
    public int StatusCode { get; set; }

    [JsonPropertyName("StatusName")]
    public string? StatusName { get; set; }

    [JsonPropertyName("StatusDescription")]
    public string? StatusDescription { get; set; }

    [JsonPropertyName("IsValid")]
    public bool IsValid { get; set; }
}
