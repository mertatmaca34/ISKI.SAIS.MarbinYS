using Application.Features.Logs.Dtos;
using MediatR;

namespace Application.Features.Logs.Queries.GetList;

public record GetLogsQuery(DateTime? StartDate, DateTime? EndDate, bool Descending)
    : IRequest<List<LogDto>>;
