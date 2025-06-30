using FluentValidation;

namespace Application.Features.MailSettings.Commands.Create;

public class CreateMailSettingsCommandValidator : AbstractValidator<CreateMailSettingsCommand>
{
    public CreateMailSettingsCommandValidator()
    {
        RuleFor(x => x.SmtpHost).NotEmpty();
        RuleFor(x => x.SmtpPort).GreaterThan(0);
        RuleFor(x => x.SmtpUser).NotEmpty();
        RuleFor(x => x.SmtpPassword).NotEmpty();
        RuleFor(x => x.SenderEmail).NotEmpty().EmailAddress();
    }
}
