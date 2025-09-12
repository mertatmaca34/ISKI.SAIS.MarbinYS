using MediatR;
using Application.Features.MailSettings.Dtos;
using AutoMapper;
using Domain.Repositories;

namespace Application.Features.MailSettings.Queries.GetList;

public class GetMailSettingsQueryHandler(
    IMailSettingsRepository repository,
    IMapper mapper) : IRequestHandler<GetMailSettingsQuery, List<MailSettingsDto>>
{
    public async Task<List<MailSettingsDto>> Handle(GetMailSettingsQuery request, CancellationToken cancellationToken)
    {
        var items = await repository.GetAllAsync(x => true);
        return items.Select(mapper.Map<MailSettingsDto>).ToList();
    }
}
