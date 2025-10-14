using System.Text.Json.Serialization;

namespace Infrastructure.Remote.SAIS.DTOs.Requests;

public sealed class SendDiagnosticWithTypeRequest
{
    [JsonPropertyName("stationId")]
    public Guid StationId { get; init; }

    [JsonPropertyName("details")]
    public string Details { get; init; } = string.Empty;

    [JsonPropertyName("DiagnosticTypeNo")]
    public int DiagnosticTypeNo { get; init; }

    [JsonPropertyName("startDate")]
    public DateTimeOffset StartDate { get; init; }
}
