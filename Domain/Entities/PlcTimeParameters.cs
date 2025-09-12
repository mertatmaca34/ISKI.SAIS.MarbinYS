using ISKI.Core.Domain;

namespace Domain.Entities;

public class PlcTimeParameters : BaseEntity<int>
{
    public DateTime SystemTime { get; set; }
    public byte WeeklyWashDay { get; set; }
    public byte WeeklyWashHour { get; set; }
    public byte DailyWashHour { get; set; }
    public byte Minute { get; set; }
    public byte Second { get; set; }
}

