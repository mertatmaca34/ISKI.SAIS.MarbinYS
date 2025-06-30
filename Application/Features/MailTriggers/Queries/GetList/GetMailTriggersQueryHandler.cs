using MediatR;
using Application.Features.MailTriggers.Dtos;
using Application.Services.Repositories;

namespace Application.Features.MailTriggers.Queries.GetList;

public class GetMailTriggersQueryHandler(IMailTriggerRepository repository) : IRequestHandler<GetMailTriggersQuery, List<MailTriggerDto>>
{
    public async Task<List<MailTriggerDto>> Handle(GetMailTriggersQuery request, CancellationToken cancellationToken)
    {
        var items = await repository.GetAllAsync(x => true);
        return items.Select(entity => new MailTriggerDto
        {
            Id = entity.Id,
            Name = entity.Name,
            SensorTag = entity.SensorTag,
            Operator = (int)entity.Operator,
            Threshold = entity.Threshold,
            CooldownMinutes = entity.CooldownMinutes,
            IsActive = entity.IsActive
        }).ToList();
    }
}
