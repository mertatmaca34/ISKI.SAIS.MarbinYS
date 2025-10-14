using System.Text.Json.Serialization;

namespace Infrastructure.Remote.SAIS.DTOs.Responses;

public sealed class ParameterInformationResponse
{
    [JsonPropertyName("Parameter")]
    public string? Parameter { get; init; }

    [JsonPropertyName("ParameterText")]
    public string? ParameterText { get; init; }

    [JsonPropertyName("MonitorType")]
    public int MonitorType { get; init; }

    [JsonPropertyName("MonitorTypeText")]
    public string? MonitorTypeText { get; init; }
}
