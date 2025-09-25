namespace Application.Features.PlcData.Dtos;

/// <summary>
/// Represents averaged analog sensor readings for a specific time window.
/// </summary>
public class AnalogSensorAverageDto
{
    public double? AkisHizi { get; set; }
    public double? Akm { get; set; }
    public double? CozunmusOksijen { get; set; }
    public double? Debi { get; set; }
    public double? Koi { get; set; }
    public double? Ph { get; set; }
    public double? Sicaklik { get; set; }
    public double? Iletkenlik { get; set; }
}
