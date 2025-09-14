using Application.Features.Users.Constants;
using FluentValidation;

namespace Application.Features.Users.Commands.Create;

public class CreateUserCommandValidator : AbstractValidator<CreateUserCommand>
{
    public CreateUserCommandValidator()
    {
        RuleFor(x => x.UserName).NotEmpty();
        RuleFor(x => x.Email)
            .NotEmpty()
            .EmailAddress()
            .WithMessage(UserMessages.InvalidEmail);
        RuleFor(x => x.Password).NotEmpty();
    }
}

