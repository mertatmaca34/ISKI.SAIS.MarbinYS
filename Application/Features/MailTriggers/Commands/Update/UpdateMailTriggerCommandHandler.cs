using MediatR;
using Application.Features.MailTriggers.Dtos;
using Application.Services.Repositories;
using AutoMapper;
using Domain.Entities;

namespace Application.Features.MailTriggers.Commands.Update;

public class UpdateMailTriggerCommandHandler(
    IMailTriggerRepository repository,
    IMapper mapper)
    : IRequestHandler<UpdateMailTriggerCommand, MailTriggerDto>
{
    public async Task<MailTriggerDto> Handle(UpdateMailTriggerCommand request, CancellationToken cancellationToken)
    {
        var entity = await repository.GetByIdAsync(request.Id);
        if (entity is null)
            throw new KeyNotFoundException($"MailTrigger {request.Id} not found");

        mapper.Map(request, entity);

        entity = await repository.UpdateAsync(entity);

        return mapper.Map<MailTriggerDto>(entity);
    }
}
