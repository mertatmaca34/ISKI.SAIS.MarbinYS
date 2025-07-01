using FluentValidation;

namespace Application.Features.CalibrationLimits.Commands.Create;

public class CreateCalibrationLimitCommandValidator : AbstractValidator<CreateCalibrationLimitCommand>
{
    public CreateCalibrationLimitCommandValidator()
    {
        RuleFor(x => x.Parameter).NotEmpty();
    }
}
