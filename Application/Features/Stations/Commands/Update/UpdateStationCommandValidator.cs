using FluentValidation;

namespace Application.Features.Stations.Commands.Update;

public class UpdateStationCommandValidator : AbstractValidator<UpdateStationCommand>
{
    public UpdateStationCommandValidator()
    {
        RuleFor(x => x.Code).NotEmpty();
        RuleFor(x => x.Name).NotEmpty();
        RuleFor(x => x.DataPeriodMinute)
            .GreaterThan((short)0)
            .When(x => x.DataPeriodMinute.HasValue);
    }
}
