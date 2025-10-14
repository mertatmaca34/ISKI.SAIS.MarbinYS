using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Api.Dtos.Sais.Requests;

public sealed class PowerOffNotificationRequestDto
{
    [JsonPropertyName("stationId")]
    [Required]
    public Guid StationId { get; set; }

    [JsonPropertyName("startTime")]
    [Required]
    public DateTime StartTime { get; set; }

    [JsonPropertyName("endTime")]
    [Required]
    public DateTime EndTime { get; set; }
}
