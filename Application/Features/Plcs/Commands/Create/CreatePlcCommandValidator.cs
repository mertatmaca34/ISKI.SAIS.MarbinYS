using FluentValidation;

namespace Application.Features.Plcs.Commands.Create;

public class CreatePlcCommandValidator : AbstractValidator<CreatePlcCommand>
{
    public CreatePlcCommandValidator()
    {
        RuleFor(x => x.IpAddress).NotEmpty();
    }
}
