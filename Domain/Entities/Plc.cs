using ISKI.Core.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Plc : BaseEntity<int>
    {
        public string IpAddress { get; set; }
    }
}
