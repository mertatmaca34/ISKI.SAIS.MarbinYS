using System.Text.Json.Serialization;

namespace Api.Dtos.Sais.Responses;

public sealed class MissingDataDto
{
    [JsonPropertyName("StartDate")]
    public DateTime StartDate { get; set; }

    [JsonPropertyName("EndDate")]
    public DateTime EndDate { get; set; }

    [JsonPropertyName("MissingDates")]
    public IReadOnlyCollection<DateTime> MissingDates { get; set; } = Array.Empty<DateTime>();
}
