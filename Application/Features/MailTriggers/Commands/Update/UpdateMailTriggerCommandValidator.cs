using FluentValidation;

namespace Application.Features.MailTriggers.Commands.Update;

public class UpdateMailTriggerCommandValidator : AbstractValidator<UpdateMailTriggerCommand>
{
    public UpdateMailTriggerCommandValidator()
    {
        RuleFor(x => x.Id).GreaterThan(0);
        RuleFor(x => x.Name).NotEmpty();
        RuleFor(x => x.SensorTag).NotEmpty();
        RuleFor(x => x.Threshold).GreaterThan(0);
        RuleFor(x => x.CooldownMinutes).GreaterThanOrEqualTo(0);
    }
}
