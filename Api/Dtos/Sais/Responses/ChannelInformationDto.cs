using System.Text.Json.Serialization;

namespace Api.Dtos.Sais.Responses;

public sealed class ChannelInformationDto
{
    [JsonPropertyName("id")]
    public Guid Id { get; set; }

    [JsonPropertyName("Brand")]
    public string? Brand { get; set; }

    [JsonPropertyName("BrandModel")]
    public string? BrandModel { get; set; }

    [JsonPropertyName("FullName")]
    public string? FullName { get; set; }

    [JsonPropertyName("Parameter")]
    public string? Parameter { get; set; }

    [JsonPropertyName("ParameterText")]
    public string? ParameterText { get; set; }

    [JsonPropertyName("Unit")]
    public Guid Unit { get; set; }

    [JsonPropertyName("UnitText")]
    public string? UnitText { get; set; }

    [JsonPropertyName("IsActive")]
    public bool IsActive { get; set; }

    [JsonPropertyName("ChannelMinValue")]
    public double? ChannelMinValue { get; set; }

    [JsonPropertyName("ChannelMaxValue")]
    public double? ChannelMaxValue { get; set; }

    [JsonPropertyName("ChannelNumber")]
    public short? ChannelNumber { get; set; }

    [JsonPropertyName("CalibrationFormulaA")]
    public double? CalibrationFormulaA { get; set; }

    [JsonPropertyName("CalibrationFormulaB")]
    public double? CalibrationFormulaB { get; set; }

    [JsonPropertyName("SerialNumber")]
    public string? SerialNumber { get; set; }
}
