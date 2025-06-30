using MediatR;
using Application.Features.MailTriggers.Dtos;
using Application.Services.Repositories;
using Domain.Entities;

namespace Application.Features.MailTriggers.Commands.Update;

public class UpdateMailTriggerCommandHandler(IMailTriggerRepository repository)
    : IRequestHandler<UpdateMailTriggerCommand, MailTriggerDto>
{
    public async Task<MailTriggerDto> Handle(UpdateMailTriggerCommand request, CancellationToken cancellationToken)
    {
        var entity = await repository.GetByIdAsync(request.Id);
        if (entity is null)
            throw new KeyNotFoundException($"MailTrigger {request.Id} not found");

        entity.Name = request.Name;
        entity.SensorTag = request.SensorTag;
        entity.Operator = request.Operator;
        entity.Threshold = request.Threshold;
        entity.CooldownMinutes = request.CooldownMinutes;
        entity.IsActive = request.IsActive;

        entity = await repository.UpdateAsync(entity);

        return new MailTriggerDto
        {
            Id = entity.Id,
            Name = entity.Name,
            SensorTag = entity.SensorTag,
            Operator = (int)entity.Operator,
            Threshold = entity.Threshold,
            CooldownMinutes = entity.CooldownMinutes,
            IsActive = entity.IsActive
        };
    }
}
