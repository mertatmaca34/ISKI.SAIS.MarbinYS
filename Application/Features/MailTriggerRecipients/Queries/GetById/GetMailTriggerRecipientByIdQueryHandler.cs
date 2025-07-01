using Application.Features.MailTriggerRecipients.Dtos;
using AutoMapper;
using Infrastructure.Persistence.Abstract;
using MediatR;

namespace Application.Features.MailTriggerRecipients.Queries.GetById;

public class GetMailTriggerRecipientByIdQueryHandler(
    IMailTriggerRecipientRepository repository,
    IMapper mapper) : IRequestHandler<GetMailTriggerRecipientByIdQuery, MailTriggerRecipientDto?>
{
    public async Task<MailTriggerRecipientDto?> Handle(GetMailTriggerRecipientByIdQuery request, CancellationToken cancellationToken)
    {
        var entity = await repository.GetByIdAsync(request.Id);
        return entity is null ? null : mapper.Map<MailTriggerRecipientDto>(entity);
    }
}
