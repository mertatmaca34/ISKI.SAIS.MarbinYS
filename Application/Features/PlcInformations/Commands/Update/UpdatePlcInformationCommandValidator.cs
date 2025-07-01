using FluentValidation;

namespace Application.Features.PlcInformations.Commands.Update;

public class UpdatePlcInformationCommandValidator : AbstractValidator<UpdatePlcInformationCommand>
{
    public UpdatePlcInformationCommandValidator()
    {
        RuleFor(x => x.Id).GreaterThan(0);
        RuleFor(x => x.IpAddress).NotEmpty();
    }
}
