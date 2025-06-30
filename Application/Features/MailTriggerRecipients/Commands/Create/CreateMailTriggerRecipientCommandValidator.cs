using FluentValidation;

namespace Application.Features.MailTriggerRecipients.Commands.Create;

public class CreateMailTriggerRecipientCommandValidator : AbstractValidator<CreateMailTriggerRecipientCommand>
{
    public CreateMailTriggerRecipientCommandValidator()
    {
        RuleFor(x => x.MailTriggerId).GreaterThan(0);
        RuleFor(x => x.MailUserId).GreaterThan(0);
    }
}
