using FluentValidation;

namespace Application.Features.PlcInformations.Commands.Create;

public class CreatePlcInformationCommandValidator : AbstractValidator<CreatePlcInformationCommand>
{
    public CreatePlcInformationCommandValidator()
    {
        RuleFor(x => x.IpAddress).NotEmpty();
    }
}
