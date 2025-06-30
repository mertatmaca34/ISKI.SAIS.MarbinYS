using FluentValidation;

namespace Application.Features.MailSettings.Commands.Update;

public class UpdateMailSettingsCommandValidator : AbstractValidator<UpdateMailSettingsCommand>
{
    public UpdateMailSettingsCommandValidator()
    {
        RuleFor(x => x.Id).GreaterThan(0);
        RuleFor(x => x.SmtpHost).NotEmpty();
        RuleFor(x => x.SmtpPort).GreaterThan(0);
        RuleFor(x => x.SmtpUser).NotEmpty();
        RuleFor(x => x.SmtpPassword).NotEmpty();
        RuleFor(x => x.SenderEmail).NotEmpty().EmailAddress();
    }
}
