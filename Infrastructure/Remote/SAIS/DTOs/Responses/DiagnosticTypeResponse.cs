using System.Text.Json.Serialization;

namespace Infrastructure.Remote.SAIS.DTOs.Responses;

public sealed class DiagnosticTypeResponse
{
    [JsonPropertyName("DiagnosticTypeNo")]
    public int DiagnosticTypeNo { get; init; }

    [JsonPropertyName("DiagnosticTypeName")]
    public string? DiagnosticTypeName { get; init; }

    [JsonPropertyName("DiagnosticLevel")]
    public int DiagnosticLevel { get; init; }

    [JsonPropertyName("DiagnosticLevel_Title")]
    public string? DiagnosticLevelTitle { get; init; }
}
