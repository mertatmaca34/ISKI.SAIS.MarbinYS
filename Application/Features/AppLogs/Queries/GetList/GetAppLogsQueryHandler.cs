using MediatR;
using Application.Features.AppLogs.Dtos;
using AutoMapper;
using Infrastructure.Persistence.Abstract;
using System.Linq;


namespace Application.Features.AppLogs.Queries.GetList;

public class GetAppLogsQueryHandler(
    IAppLogRepository repository,
    IMapper mapper) : IRequestHandler<GetAppLogsQuery, List<AppLogDto>>
{
    public async Task<List<AppLogDto>> Handle(GetAppLogsQuery request, CancellationToken cancellationToken)
    {
        DateTime start = request.StartDate ?? DateTime.MinValue;
        DateTime end = request.EndDate ?? DateTime.MaxValue;

        var logs = await repository.GetAllAsync(x => x.LoggedAt >= start && x.LoggedAt <= end);
        logs = request.Descending
            ? logs.OrderByDescending(x => x.LoggedAt).ToList()
            : logs.OrderBy(x => x.LoggedAt).ToList();

        return logs.Select(mapper.Map<AppLogDto>).ToList();
    }
}
