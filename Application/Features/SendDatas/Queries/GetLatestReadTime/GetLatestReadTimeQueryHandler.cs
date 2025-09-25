using Domain.Repositories;
using MediatR;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Features.SendDatas.Queries.GetLatestReadTime;

public class GetLatestReadTimeQueryHandler(ISendDataRepository repository)
    : IRequestHandler<GetLatestReadTimeQuery, DateTime?>
{
    public async Task<DateTime?> Handle(GetLatestReadTimeQuery request, CancellationToken cancellationToken)
    {
        var items = await repository.GetAllAsync(_ => true, query =>
            query.OrderByDescending(x => x.Readtime).Take(1));

        return items.FirstOrDefault()?.Readtime;
    }
}
