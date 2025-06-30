using FluentValidation;

namespace Application.Features.MailTriggers.Commands.Create;

public class CreateMailTriggerCommandValidator : AbstractValidator<CreateMailTriggerCommand>
{
    public CreateMailTriggerCommandValidator()
    {
        RuleFor(x => x.Name).NotEmpty();
        RuleFor(x => x.SensorTag).NotEmpty();
        RuleFor(x => x.Threshold).GreaterThan(0);
        RuleFor(x => x.CooldownMinutes).GreaterThanOrEqualTo(0);
    }
}
