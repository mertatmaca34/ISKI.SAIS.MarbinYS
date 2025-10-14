using System.Text.Json.Serialization;

namespace Infrastructure.Remote.SAIS.DTOs.Requests;

public sealed class SendDiagnosticRequest
{
    [JsonPropertyName("stationId")]
    public Guid StationId { get; init; }

    [JsonPropertyName("details")]
    public string Details { get; init; } = string.Empty;

    [JsonPropertyName("startDate")]
    public DateTimeOffset StartDate { get; init; }
}
