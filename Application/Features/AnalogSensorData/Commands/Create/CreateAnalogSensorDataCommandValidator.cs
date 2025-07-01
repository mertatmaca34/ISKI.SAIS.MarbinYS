using FluentValidation;

namespace Application.Features.AnalogSensorData.Commands.Create;

public class CreateAnalogSensorDataCommandValidator : AbstractValidator<CreateAnalogSensorDataCommand>
{
    public CreateAnalogSensorDataCommandValidator()
    {
        RuleFor(x => x.Readtime).NotEmpty();
    }
}
