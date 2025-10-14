using System.Text.Json.Serialization;

namespace Infrastructure.Remote.SAIS.DTOs.Requests;

public sealed class PowerOffNotificationRequest
{
    [JsonPropertyName("stationId")]
    public Guid StationId { get; init; }

    [JsonPropertyName("startTime")]
    public DateTimeOffset StartTime { get; init; }

    [JsonPropertyName("endTime")]
    public DateTimeOffset EndTime { get; init; }
}
