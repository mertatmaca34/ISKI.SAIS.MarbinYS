using MediatR;
using Domain.Entities;
using Application.Features.MailTriggers.Dtos;
using Domain.Enums;

namespace Application.Features.MailTriggers.Commands.Create;

public record CreateMailTriggerCommand(
    string Name,
    string SensorTag,
    ComparisonOperator Operator,
    double Threshold,
    int CooldownMinutes,
    bool IsActive
) : IRequest<MailTriggerDto>;
