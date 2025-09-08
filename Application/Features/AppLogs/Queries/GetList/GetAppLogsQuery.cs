using MediatR;
using Application.Features.AppLogs.Dtos;

namespace Application.Features.AppLogs.Queries.GetList;

public record GetAppLogsQuery(DateTime? StartDate, DateTime? EndDate, bool Descending)
    : IRequest<List<AppLogDto>>;
