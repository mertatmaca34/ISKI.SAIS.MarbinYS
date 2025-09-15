using Application.Features.MailAlarms.Dtos;
using MediatR;

namespace Application.Features.MailAlarms.Queries.GetList;

public class GetMailAlarmsQuery(int userId) : IRequest<List<MailAlarmDto>>
{
    public int UserId { get; } = userId;
}

