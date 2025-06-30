using FluentValidation;

namespace Application.Features.MailUsers.Commands.Create;

public class CreateMailUserCommandValidator : AbstractValidator<CreateMailUserCommand>
{
    public CreateMailUserCommandValidator()
    {
        RuleFor(x => x.FullName).NotEmpty();
        RuleFor(x => x.Email).NotEmpty().EmailAddress();
    }
}
