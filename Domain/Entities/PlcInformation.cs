using ISKI.Core.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities;

/// <summary>
/// Basic PLC connection information.
/// </summary>
public class PlcInformation : BaseEntity<int>
{
    public string IpAddress { get; set; }
}

