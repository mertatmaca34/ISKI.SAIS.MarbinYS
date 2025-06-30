using MediatR;
using Application.Features.MailTriggers.Dtos;
using Domain.Enums;

namespace Application.Features.MailTriggers.Commands.Update;

public record UpdateMailTriggerCommand(
    int Id,
    string Name,
    string SensorTag,
    ComparisonOperator Operator,
    double Threshold,
    int CooldownMinutes,
    bool IsActive
) : IRequest<MailTriggerDto>;
