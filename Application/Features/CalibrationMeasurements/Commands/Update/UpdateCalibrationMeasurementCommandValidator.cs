using FluentValidation;

namespace Application.Features.CalibrationMeasurements.Commands.Update;

public class UpdateCalibrationMeasurementCommandValidator : AbstractValidator<UpdateCalibrationMeasurementCommand>
{
    public UpdateCalibrationMeasurementCommandValidator()
    {
        RuleFor(x => x.Id).GreaterThan(0);
        RuleFor(x => x.Parameter).NotEmpty();
    }
}
