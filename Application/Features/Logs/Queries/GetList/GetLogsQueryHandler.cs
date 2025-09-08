using Application.Features.Logs.Dtos;
using Infrastructure.Persistence;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace Application.Features.Logs.Queries.GetList;

public class GetLogsQueryHandler(IBKSContext context) : IRequestHandler<GetLogsQuery, List<LogDto>>
{
    public async Task<List<LogDto>> Handle(GetLogsQuery request, CancellationToken cancellationToken)
    {
        DateTime start = request.StartDate ?? DateTime.MinValue;
        DateTime end = request.EndDate ?? DateTime.MaxValue;

        var query = context.Logs
            .Where(x => x.TimeStamp >= start && x.TimeStamp <= end);

        query = request.Descending
            ? query.OrderByDescending(x => x.TimeStamp)
            : query.OrderBy(x => x.TimeStamp);

        var logs = await query.ToListAsync(cancellationToken);

        return logs.Select(x => new LogDto
        {
            Id = x.Id,
            Level = x.Level,
            Message = x.Message,
            Exception = x.Exception,
            LoggedAt = x.TimeStamp
        }).ToList();
    }
}
