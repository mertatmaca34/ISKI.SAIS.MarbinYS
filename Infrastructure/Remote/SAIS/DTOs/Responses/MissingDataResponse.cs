using System.Text.Json.Serialization;

namespace Infrastructure.Remote.SAIS.DTOs.Responses;

public sealed class MissingDataResponse
{
    [JsonPropertyName("StartDate")]
    public DateTimeOffset StartDate { get; init; }

    [JsonPropertyName("EndDate")]
    public DateTimeOffset EndDate { get; init; }

    [JsonPropertyName("MissingDates")]
    public IReadOnlyCollection<DateTimeOffset> MissingDates { get; init; } = Array.Empty<DateTimeOffset>();
}
