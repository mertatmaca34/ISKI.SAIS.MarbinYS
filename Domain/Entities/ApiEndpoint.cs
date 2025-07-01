using ISKI.Core.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities;

public class ApiEndpoint : BaseEntity<int>
{
    public string ApiAdress { get; set; }
    public string UserName { get; set; }
    public string Password { get; set; }
}
