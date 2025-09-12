using MediatR;
using Application.Features.MailTriggers.Dtos;
using AutoMapper;
using Domain.Repositories;

namespace Application.Features.MailTriggers.Queries.GetList;

public class GetMailTriggersQueryHandler(
    IMailTriggerRepository repository,
    IMapper mapper) : IRequestHandler<GetMailTriggersQuery, List<MailTriggerDto>>
{
    public async Task<List<MailTriggerDto>> Handle(GetMailTriggersQuery request, CancellationToken cancellationToken)
    {
        var items = await repository.GetAllAsync(x => true);
        return items.Select(mapper.Map<MailTriggerDto>).ToList();
    }
}
