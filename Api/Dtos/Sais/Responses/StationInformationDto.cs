using System.Text.Json.Serialization;

namespace Api.Dtos.Sais.Responses;

public sealed class StationInformationDto
{
    [JsonPropertyName("StationId")]
    public Guid StationId { get; set; }

    [JsonPropertyName("Code")]
    public string? Code { get; set; }

    [JsonPropertyName("Name")]
    public string? Name { get; set; }

    [JsonPropertyName("DataPeriodMinute")]
    public short? DataPeriodMinute { get; set; }

    [JsonPropertyName("LastDataDate")]
    public DateTime? LastDataDate { get; set; }

    [JsonPropertyName("ConnectionDomainAddress")]
    public string? ConnectionDomainAddress { get; set; }

    [JsonPropertyName("ConnectionPort")]
    public int? ConnectionPort { get; set; }

    [JsonPropertyName("ConnectionUser")]
    public string? ConnectionUser { get; set; }

    [JsonPropertyName("ConnectionPassword")]
    public string? ConnectionPassword { get; set; }

    [JsonPropertyName("Company")]
    public string? Company { get; set; }

    [JsonPropertyName("BirtDate")]
    public DateTime? BirthDate { get; set; }

    [JsonPropertyName("SetupDate")]
    public DateTime? SetupDate { get; set; }

    [JsonPropertyName("Adress")]
    public string? Address { get; set; }

    [JsonPropertyName("Software")]
    public string? Software { get; set; }
}
