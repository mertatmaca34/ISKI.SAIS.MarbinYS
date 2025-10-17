using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Api.Dtos.Sais.Requests;

public sealed class ChannelUpdateRequestDto
{
    [JsonPropertyName("id")]
    [Required]
    public Guid Id { get; set; }

    [JsonPropertyName("Unit")]
    [Required]
    public Guid Unit { get; set; }

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
}
