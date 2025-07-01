using ISKI.Core.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities;

public class CalibrationMeasurement : BaseEntity<int>
{
    public DateTime TimeStamp { get; set; }
    public string Parameter { get; set; }
    public double ZeroRef { get; set; }
    public double ZeroMeas { get; set; }
    public double ZeroDiff { get; set; }
    public double ZeroStd { get; set; }
    public double SpanRef { get; set; }
    public double SpanMeas { get; set; }
    public double SpanDiff { get; set; }
    public double SpanStd { get; set; }
    public double ResultFactor { get; set; }
    public bool IsItValid { get; set; }
}
