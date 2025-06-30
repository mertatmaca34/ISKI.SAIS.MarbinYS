using ISKI.Core.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities;

public class Station : BaseEntity<int>
{
    public string StationName { get; set; }
    public Guid StationId { get; set; }
}
