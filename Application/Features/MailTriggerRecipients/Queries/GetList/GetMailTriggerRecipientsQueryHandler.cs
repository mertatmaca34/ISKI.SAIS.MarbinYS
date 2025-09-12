using Application.Features.MailTriggerRecipients.Dtos;
using AutoMapper;
using Domain.Repositories;
using MediatR;

namespace Application.Features.MailTriggerRecipients.Queries.GetList;

public class GetMailTriggerRecipientsQueryHandler(
    IMailTriggerRecipientRepository repository,
    IMapper mapper) : IRequestHandler<GetMailTriggerRecipientsQuery, List<MailTriggerRecipientDto>>
{
    public async Task<List<MailTriggerRecipientDto>> Handle(GetMailTriggerRecipientsQuery request, CancellationToken cancellationToken)
    {
        var entities = await repository.GetAllAsync(x => true);
        return entities.Select(mapper.Map<MailTriggerRecipientDto>).ToList();
    }
}
