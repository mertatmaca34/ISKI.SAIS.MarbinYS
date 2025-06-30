using MediatR;
using Application.Features.MailLogs.Dtos;
using Application.Services.Repositories;

namespace Application.Features.MailLogs.Queries.GetList;

public class GetMailLogsQueryHandler(IMailLogRepository repository) : IRequestHandler<GetMailLogsQuery, List<MailLogDto>>
{
    public async Task<List<MailLogDto>> Handle(GetMailLogsQuery request, CancellationToken cancellationToken)
    {
        var items = await repository.GetAllAsync(x => true);
        return items.Select(entity => new MailLogDto
        {
            Id = entity.Id,
            MailTriggerId = entity.MailTriggerId,
            RecipientEmail = entity.RecipientEmail,
            SentAt = entity.SentAt,
            IsSuccess = entity.IsSuccess,
            ErrorMessage = entity.ErrorMessage,
            BodySnapshot = entity.BodySnapshot
        }).ToList();
    }
}
