using FluentValidation;

namespace Application.Features.AnalogSensorDatas.Commands.Update;

public class UpdateAnalogSensorDataCommandValidator : AbstractValidator<UpdateAnalogSensorDataCommand>
{
    public UpdateAnalogSensorDataCommandValidator()
    {
        RuleFor(x => x.Id).GreaterThan(0);
        RuleFor(x => x.Readtime).NotEmpty();
    }
}
