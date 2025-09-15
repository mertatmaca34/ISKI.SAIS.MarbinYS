using MediatR;

namespace Application.Features.MailAlarms.Commands.UpdateUser;

public class UpdateUserMailAlarmsCommand(int userId, List<int> alarmIds) : IRequest<Unit>
{
    public int UserId { get; } = userId;
    public List<int> AlarmIds { get; } = alarmIds;
}

