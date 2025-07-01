using FluentValidation;

namespace Application.Features.DigitalSensorData.Commands.Update;

public class UpdateDigitalSensorDataCommandValidator : AbstractValidator<UpdateDigitalSensorDataCommand>
{
    public UpdateDigitalSensorDataCommandValidator()
    {
        RuleFor(x => x.Id).GreaterThan(0);
        RuleFor(x => x.ReadTime).NotEmpty();
    }
}
