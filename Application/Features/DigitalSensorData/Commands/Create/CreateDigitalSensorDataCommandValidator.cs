using FluentValidation;

namespace Application.Features.DigitalSensorData.Commands.Create;

public class CreateDigitalSensorDataCommandValidator : AbstractValidator<CreateDigitalSensorDataCommand>
{
    public CreateDigitalSensorDataCommandValidator()
    {
        RuleFor(x => x.ReadTime).NotEmpty();
    }
}
