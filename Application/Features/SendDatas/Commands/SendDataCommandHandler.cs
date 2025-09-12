using Application.Features.SendDatas.Dtos;
using AutoMapper;
using Domain.Entities;
using Domain.Enums;
using Domain.Repositories;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Application.Features.SendDatas.Commands;

public class SendDataCommandHandler(
    IMailTriggerRepository triggerRepository,
    IMailLogRepository logRepository,
    IMapper mapper) : IRequestHandler<SendDataCommand, SendDataResultDto>
{
    public async Task<SendDataResultDto> Handle(SendDataCommand request, CancellationToken cancellationToken)
    {
        var triggers = await triggerRepository.GetAllAsync(
            t => t.SensorTag == request.SensorTag && t.IsActive,
            q => q.Include(t => t.Recipients).ThenInclude(r => r.MailUser));

        int sentCount = 0;
        foreach (var trigger in triggers)
        {
            bool conditionMet = trigger.Operator switch
            {
                ComparisonOperator.GreaterThan => request.Value > trigger.Threshold,
                ComparisonOperator.LessThan => request.Value < trigger.Threshold,
                ComparisonOperator.Equal => request.Value == trigger.Threshold,
                ComparisonOperator.GreaterOrEqual => request.Value >= trigger.Threshold,
                ComparisonOperator.LessOrEqual => request.Value <= trigger.Threshold,
                _ => false
            };

            if (!conditionMet)
                continue;

            var cooldownPassed = trigger.LastMailSentAt is null ||
                trigger.LastMailSentAt.Value.AddMinutes(trigger.CooldownMinutes) <= DateTime.UtcNow;

            if (!cooldownPassed)
                continue;

            foreach (var recipient in trigger.Recipients)
            {
                var log = new MailLog
                {
                    MailTriggerId = trigger.Id,
                    RecipientEmail = recipient.MailUser.Email,
                    SentAt = DateTime.UtcNow,
                    IsSuccess = true,
                    ErrorMessage = string.Empty,
                    BodySnapshot = $"SensorTag: {request.SensorTag}, Value: {request.Value}"
                };

                await logRepository.AddAsync(log);
                sentCount++;
            }

            trigger.LastMailSentAt = DateTime.UtcNow;
            await triggerRepository.UpdateAsync(trigger);
        }

        return new SendDataResultDto { SentMailCount = sentCount };
    }
}
