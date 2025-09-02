using ISKI.Core.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities;

public class Station : BaseEntity<int>
{
    public Guid StationId { get; set; }
    public string Code { get; set; }
    public string Name { get; set; }
    public int DataPeriodMinute { get; set; }
    public DateTime LastDataDate { get; set; }
    public string ConnectionDomainAddress { get; set; }
    public string ConnectionPort { get; set; }
    public string ConnectionUser { get; set; }
    public string ConnectionPassword { get; set; }
    public string Company { get; set; }
    public DateTime BirtDate { get; set; }
    public DateTime SetupDate { get; set; }
    public string Address { get; set; }
    public string Software { get; set; }
}