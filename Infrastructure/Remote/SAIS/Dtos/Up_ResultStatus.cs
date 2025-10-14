using System.Text.Json.Serialization;

namespace Infrastructure.Remote.SAIS.Dtos;

// Dokümandaki ResultStatus yapısı: result/message/objects
internal sealed record Up_ResultStatus<T>(
    [property: JsonPropertyName("result")] bool Result,
    [property: JsonPropertyName("message")] string? Message,
    [property: JsonPropertyName("objects")] T? Objects
);
