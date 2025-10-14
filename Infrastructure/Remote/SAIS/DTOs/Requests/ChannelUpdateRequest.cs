using System.Text.Json.Serialization;

namespace Infrastructure.Remote.SAIS.DTOs.Requests;

public sealed class ChannelUpdateRequest
{
    [JsonPropertyName("id")]
    public Guid Id { get; init; }

    [JsonPropertyName("Unit")]
    public Guid Unit { get; init; }

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
}
