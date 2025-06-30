using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISKI.Core.Persistence.Paging;

public class PaginatedList<T> : BasePageableModel
{
    public List<T> Items { get; set; } = new();
}
