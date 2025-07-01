using FluentValidation;

namespace Application.Features.CalibrationLimits.Commands.Update;

public class UpdateCalibrationLimitCommandValidator : AbstractValidator<UpdateCalibrationLimitCommand>
{
    public UpdateCalibrationLimitCommandValidator()
    {
        RuleFor(x => x.Id).GreaterThan(0);
        RuleFor(x => x.Parameter).NotEmpty();
    }
}
