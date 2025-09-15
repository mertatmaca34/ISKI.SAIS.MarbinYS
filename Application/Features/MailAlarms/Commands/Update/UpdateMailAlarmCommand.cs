using Application.Features.MailAlarms.Dtos;
using MediatR;

namespace Application.Features.MailAlarms.Commands.Update;

public record UpdateMailAlarmCommand(int Id, double Limit) : IRequest<MailAlarmDto>;
