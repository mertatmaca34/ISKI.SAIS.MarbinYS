using System.Text.Json.Serialization;

namespace Api.Dtos.Sais.Responses;

public sealed class ParameterInformationDto
{
    [JsonPropertyName("Parameter")]
    public string? Parameter { get; set; }

    [JsonPropertyName("ParameterText")]
    public string? ParameterText { get; set; }

    [JsonPropertyName("MonitorType")]
    public int MonitorType { get; set; }

    [JsonPropertyName("MonitorTypeText")]
    public string? MonitorTypeText { get; set; }
}
