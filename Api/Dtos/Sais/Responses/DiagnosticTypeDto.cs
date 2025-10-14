using System.Text.Json.Serialization;

namespace Api.Dtos.Sais.Responses;

public sealed class DiagnosticTypeDto
{
    [JsonPropertyName("DiagnosticTypeNo")]
    public int DiagnosticTypeNo { get; set; }

    [JsonPropertyName("DiagnosticTypeName")]
    public string? DiagnosticTypeName { get; set; }

    [JsonPropertyName("DiagnosticLevel")]
    public int DiagnosticLevel { get; set; }

    [JsonPropertyName("DiagnosticLevel_Title")]
    public string? DiagnosticLevelTitle { get; set; }
}
