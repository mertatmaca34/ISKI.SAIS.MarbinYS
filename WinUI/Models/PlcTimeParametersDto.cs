using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinUI.Models;

public class PlcTimeParametersDto
{
    public int Id { get; set; }
    public DateTime SystemTime { get; set; }
    public byte WeeklyWashDay { get; set; }
    public byte WeeklyWashHour { get; set; }
    public byte DailyWashHour { get; set; }
    public byte Minute { get; set; }
    public byte Second { get; set; }
}
