using Application.Features.MailAlarms.Dtos;
using Domain.Enums;
using MediatR;

namespace Application.Features.MailAlarms.Commands.Update;

public record UpdateMailAlarmCommand(
    int Id,
    string Name,
    string Channel,
    double Limit,
    string MailSubject,
    string MailBody,
    MailTemplateType TemplateType) : IRequest<MailAlarmDto>;
