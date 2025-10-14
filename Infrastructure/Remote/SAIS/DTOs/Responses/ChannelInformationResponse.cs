using System.Text.Json.Serialization;

namespace Infrastructure.Remote.SAIS.DTOs.Responses;

public sealed class ChannelInformationResponse
{
    [JsonPropertyName("id")]
    public Guid Id { get; init; }

    [JsonPropertyName("Brand")]
    public string? Brand { get; init; }

    [JsonPropertyName("BrandModel")]
    public string? BrandModel { get; init; }

    [JsonPropertyName("FullName")]
    public string? FullName { get; init; }

    [JsonPropertyName("Parameter")]
    public string? Parameter { get; init; }

    [JsonPropertyName("ParameterText")]
    public string? ParameterText { get; init; }

    [JsonPropertyName("Unit")]
    public Guid Unit { get; init; }

    [JsonPropertyName("UnitText")]
    public string? UnitText { get; init; }

    [JsonPropertyName("IsActive")]
    public bool IsActive { get; init; }

    [JsonPropertyName("ChannelMinValue")]
    public double ChannelMinValue { get; init; }

    [JsonPropertyName("ChannelMaxValue")]
    public double ChannelMaxValue { get; init; }

    [JsonPropertyName("ChannelNumber")]
    public short ChannelNumber { get; init; }

    [JsonPropertyName("CalibrationFormulaA")]
    public double CalibrationFormulaA { get; init; }

    [JsonPropertyName("CalibrationFormulaB")]
    public double CalibrationFormulaB { get; init; }

    [JsonPropertyName("SerialNumber")]
    public string? SerialNumber { get; init; }
}
