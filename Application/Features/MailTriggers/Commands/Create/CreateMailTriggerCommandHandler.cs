using MediatR;
using Application.Features.MailTriggers.Dtos;
using Domain.Entities;
using Application.Services.Repositories;

namespace Application.Features.MailTriggers.Commands.Create;

public class CreateMailTriggerCommandHandler(IMailTriggerRepository repository) : IRequestHandler<CreateMailTriggerCommand, MailTriggerDto>
{
    public async Task<MailTriggerDto> Handle(CreateMailTriggerCommand request, CancellationToken cancellationToken)
    {
        var entity = new MailTrigger
        {
            Name = request.Name,
            SensorTag = request.SensorTag,
            Operator = request.Operator,
            Threshold = request.Threshold,
            CooldownMinutes = request.CooldownMinutes,
            IsActive = request.IsActive
        };

        entity = await repository.AddAsync(entity);

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
