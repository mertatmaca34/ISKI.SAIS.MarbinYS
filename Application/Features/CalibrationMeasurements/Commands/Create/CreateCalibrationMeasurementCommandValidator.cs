using FluentValidation;

namespace Application.Features.CalibrationMeasurements.Commands.Create;

public class CreateCalibrationMeasurementCommandValidator : AbstractValidator<CreateCalibrationMeasurementCommand>
{
    public CreateCalibrationMeasurementCommandValidator()
    {
        RuleFor(x => x.Parameter).NotEmpty();
    }
}
