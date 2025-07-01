using FluentValidation;

namespace Application.Features.DigitalSensorDatas.Commands.Create;

public class CreateDigitalSensorDataCommandValidator : AbstractValidator<CreateDigitalSensorDataCommand>
{
    public CreateDigitalSensorDataCommandValidator()
    {
        RuleFor(x => x.ReadTime).NotEmpty();
    }
}
