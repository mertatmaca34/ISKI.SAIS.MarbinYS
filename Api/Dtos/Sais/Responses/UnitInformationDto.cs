using System.Text.Json.Serialization;

namespace Api.Dtos.Sais.Responses;

public sealed class UnitInformationDto
{
    [JsonPropertyName("id")]
    public Guid Id { get; set; }

    [JsonPropertyName("Name")]
    public string? Name { get; set; }
}
