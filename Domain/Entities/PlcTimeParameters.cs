namespace Domain.Entities;

/// <summary>
/// Represents time configuration parameters read from the PLC.
/// These values are not persisted but mapped to DTOs when requested.
/// </summary>
public class PlcTimeParameters
{
    public DateTime SystemTime { get; set; }
    public byte WeeklyWashDay { get; set; }
    public byte WeeklyWashHour { get; set; }
    public byte DailyWashHour { get; set; }
    public byte Minute { get; set; }
    public byte Second { get; set; }
}
