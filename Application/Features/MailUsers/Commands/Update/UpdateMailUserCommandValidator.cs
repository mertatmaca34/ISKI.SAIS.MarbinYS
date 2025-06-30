using FluentValidation;

namespace Application.Features.MailUsers.Commands.Update;

public class UpdateMailUserCommandValidator : AbstractValidator<UpdateMailUserCommand>
{
    public UpdateMailUserCommandValidator()
    {
        RuleFor(x => x.Id).GreaterThan(0);
        RuleFor(x => x.FullName).NotEmpty();
        RuleFor(x => x.Email).NotEmpty().EmailAddress();
    }
}
