using Domain.Entities;
using Domain.Repositories;
using MediatR;

namespace Application.Features.MailAlarms.Commands.UpdateUser;

public class UpdateUserMailAlarmsCommandHandler(
    IMailAlarmRepository alarmRepository,
    IUserMailAlarmRepository userAlarmRepository) : IRequestHandler<UpdateUserMailAlarmsCommand>
{
    public async Task<Unit> Handle(UpdateUserMailAlarmsCommand request, CancellationToken cancellationToken)
    {
        var alarms = await alarmRepository.GetAllAsync(x => true);
        var userRecords = await userAlarmRepository.GetAllAsync(x => x.UserId == request.UserId);
        foreach (var alarm in alarms)
        {
            var record = userRecords.FirstOrDefault(x => x.MailAlarmId == alarm.Id);
            bool isActive = request.AlarmIds.Contains(alarm.Id);
            if (record == null)
            {
                if (isActive)
                {
                    await userAlarmRepository.AddAsync(new UserMailAlarm
                    {
                        UserId = request.UserId,
                        MailAlarmId = alarm.Id,
                        IsActive = true
                    });
                }
            }
            else
            {
                record.IsActive = isActive;
                await userAlarmRepository.UpdateAsync(record);
            }
        }

        return Unit.Value;
    }
}

