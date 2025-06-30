using MediatR;
using Application.Features.MailLogs.Dtos;

namespace Application.Features.MailLogs.Queries.GetList;

public record GetMailLogsQuery() : IRequest<List<MailLogDto>>;
