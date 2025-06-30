using MediatR;
using Application.Features.MailSettings.Dtos;
using Application.Services.Repositories;

namespace Application.Features.MailSettings.Queries.GetList;

public class GetMailSettingsQueryHandler(IMailSettingsRepository repository) : IRequestHandler<GetMailSettingsQuery, List<MailSettingsDto>>
{
    public async Task<List<MailSettingsDto>> Handle(GetMailSettingsQuery request, CancellationToken cancellationToken)
    {
        var items = await repository.GetAllAsync(x => true);
        return items.Select(entity => new MailSettingsDto
        {
            Id = entity.Id,
            SmtpHost = entity.SmtpHost,
            SmtpPort = entity.SmtpPort,
            SmtpUser = entity.SmtpUser,
            UseSsl = entity.UseSsl,
            SenderEmail = entity.SenderEmail,
            SenderName = entity.SenderName
        }).ToList();
    }
}
