using FluentValidation;

namespace Application.Features.Stations.Commands.Update;

public class UpdateStationCommandValidator : AbstractValidator<UpdateStationCommand>
{
    public UpdateStationCommandValidator()
    {
        RuleFor(x => x.Id).GreaterThan(0);
        RuleFor(x => x.Code).NotEmpty();
        RuleFor(x => x.Name).NotEmpty();
        RuleFor(x => x.DataPeriodMinute).GreaterThan(0);
    }
}
