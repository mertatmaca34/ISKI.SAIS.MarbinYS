using System.Text.Json.Serialization;

namespace Infrastructure.Remote.SAIS.DTOs.Responses;

public sealed class StationInformationResponse
{
    [JsonPropertyName("StationId")]
    public Guid StationId { get; init; }

    [JsonPropertyName("Code")]
    public string? Code { get; init; }

    [JsonPropertyName("Name")]
    public string? Name { get; init; }

    [JsonPropertyName("DataPeriodMinute")]
    public int DataPeriodMinute { get; init; }

    [JsonPropertyName("LastDataDate")]
    public DateTimeOffset? LastDataDate { get; init; }

    [JsonPropertyName("ConnectionDomainAddress")]
    public string? ConnectionDomainAddress { get; init; }

    [JsonPropertyName("ConnectionPort")]
    public string? ConnectionPort { get; init; }

    [JsonPropertyName("ConnectionUser")]
    public string? ConnectionUser { get; init; }

    [JsonPropertyName("ConnectionPassword")]
    public string? ConnectionPassword { get; init; }

    [JsonPropertyName("Company")]
    public string? Company { get; init; }

    [JsonPropertyName("BirtDate")]
    public DateTimeOffset? BirthDate { get; init; }

    [JsonPropertyName("SetupDate")]
    public DateTimeOffset? SetupDate { get; init; }

    [JsonPropertyName("Adress")]
    public string? Address { get; init; }

    [JsonPropertyName("Software")]
    public string? Software { get; init; }
}
