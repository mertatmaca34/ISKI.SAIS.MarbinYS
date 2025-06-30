using MediatR;
using Application.Features.MailTriggers.Dtos;
using Application.Services.Repositories;
using AutoMapper;
using Domain.Entities;

namespace Application.Features.MailTriggers.Commands.Create;

public class CreateMailTriggerCommandHandler(
    IMailTriggerRepository repository,
    IMapper mapper) : IRequestHandler<CreateMailTriggerCommand, MailTriggerDto>
{
    public async Task<MailTriggerDto> Handle(CreateMailTriggerCommand request, CancellationToken cancellationToken)
    {
        var entity = mapper.Map<MailTrigger>(request);

        entity = await repository.AddAsync(entity);

        return mapper.Map<MailTriggerDto>(entity);
    }
}
