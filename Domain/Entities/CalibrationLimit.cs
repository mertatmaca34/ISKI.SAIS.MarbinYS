using ISKI.Core.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities;

public class CalibrationLimit : BaseEntity<int>
{
    public string Parameter { get; set; }
    public int ZeroRef { get; set; }
    public int ZeroTimeStamp { get; set; }
    public int SpanRef { get; set; }
    public int SpanTimeStamp { get; set; }
}
