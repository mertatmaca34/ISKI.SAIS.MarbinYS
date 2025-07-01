using FluentValidation;

namespace Application.Features.Stations.Commands.Update;

public class UpdateStationCommandValidator : AbstractValidator<UpdateStationCommand>
{
    public UpdateStationCommandValidator()
    {
        RuleFor(x => x.Id).GreaterThan(0);
        RuleFor(x => x.StationName).NotEmpty();
    }
}
