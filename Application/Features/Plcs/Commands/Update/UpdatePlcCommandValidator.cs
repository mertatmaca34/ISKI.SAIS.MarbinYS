using FluentValidation;

namespace Application.Features.Plcs.Commands.Update;

public class UpdatePlcCommandValidator : AbstractValidator<UpdatePlcCommand>
{
    public UpdatePlcCommandValidator()
    {
        RuleFor(x => x.Id).GreaterThan(0);
        RuleFor(x => x.IpAddress).NotEmpty();
    }
}
