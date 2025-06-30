using Application.Features.MailTriggerRecipients.Dtos;
using Application.Services.Repositories;
using AutoMapper;
using Domain.Entities;
using MediatR;

namespace Application.Features.MailTriggerRecipients.Commands.Create;

public class CreateMailTriggerRecipientCommandHandler(
    IMailTriggerRecipientRepository repository,
    IMapper mapper)
    : IRequestHandler<CreateMailTriggerRecipientCommand, MailTriggerRecipientDto>
{
    public async Task<MailTriggerRecipientDto> Handle(CreateMailTriggerRecipientCommand request, CancellationToken cancellationToken)
    {
        var entity = mapper.Map<MailTriggerRecipient>(request);
        entity = await repository.AddAsync(entity);
        return mapper.Map<MailTriggerRecipientDto>(entity);
    }
}
