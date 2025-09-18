using Application.Features.MailAlarms.Dtos;
using Domain.Repositories;
using MediatR;

namespace Application.Features.MailAlarms.Queries.GetList;

public class GetMailAlarmsQueryHandler(
    IMailAlarmRepository alarmRepository,
    IUserMailAlarmRepository userAlarmRepository) : IRequestHandler<GetMailAlarmsQuery, List<MailAlarmDto>>
{
    public async Task<List<MailAlarmDto>> Handle(GetMailAlarmsQuery request, CancellationToken cancellationToken)
    {
        var alarms = await alarmRepository.GetAllAsync(x => true);
        var active = await userAlarmRepository.GetAllAsync(x => x.UserId == request.UserId && x.IsActive);
        var activeSet = active.Select(x => x.MailAlarmId).ToHashSet();
        return alarms.Select(a => new MailAlarmDto
        {
            Id = a.Id,
            Name = a.Name,
            Channel = a.Channel,
            Limit = a.Limit,
            MailSubject = a.MailSubject,
            MailBody = a.MailBody,
            IsActive = activeSet.Contains(a.Id),
            TemplateType = a.TemplateType
        }).ToList();
    }
}

