using MediatR;
using Application.Features.MailLogs.Dtos;
using AutoMapper;
using Infrastructure.Persistence.Abstract;

namespace Application.Features.MailLogs.Queries.GetList;

public class GetMailLogsQueryHandler(
    IMailLogRepository repository,
    IMapper mapper) : IRequestHandler<GetMailLogsQuery, List<MailLogDto>>
{
    public async Task<List<MailLogDto>> Handle(GetMailLogsQuery request, CancellationToken cancellationToken)
    {
        var items = await repository.GetAllAsync(x => true);
        return items.Select(mapper.Map<MailLogDto>).ToList();
    }
}
