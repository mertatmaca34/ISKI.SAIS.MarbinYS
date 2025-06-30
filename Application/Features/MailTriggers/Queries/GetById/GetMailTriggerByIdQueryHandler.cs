using MediatR;
using Application.Features.MailTriggers.Dtos;
using Application.Services.Repositories;

namespace Application.Features.MailTriggers.Queries.GetById;

public class GetMailTriggerByIdQueryHandler(IMailTriggerRepository repository)
    : IRequestHandler<GetMailTriggerByIdQuery, MailTriggerDto?>
{
    public async Task<MailTriggerDto?> Handle(GetMailTriggerByIdQuery request, CancellationToken cancellationToken)
    {
        var entity = await repository.GetByIdAsync(request.Id);
        if (entity is null)
            return null;

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
