using Application.Features.MailSettings.Dtos;
using AutoMapper;
using Domain.Repositories;
using MediatR;

namespace Application.Features.MailSettings.Queries.GetById;

public class GetMailSettingsByIdQueryHandler(
    IMailSettingsRepository repository,
    IMapper mapper) : IRequestHandler<GetMailSettingsByIdQuery, MailSettingsDto?>
{
    public async Task<MailSettingsDto?> Handle(GetMailSettingsByIdQuery request, CancellationToken cancellationToken)
    {
        var entity = await repository.GetByIdAsync(request.Id);
        return entity is null ? null : mapper.Map<MailSettingsDto>(entity);
    }
}
