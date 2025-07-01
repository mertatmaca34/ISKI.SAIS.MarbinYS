using FluentValidation;

namespace Application.Features.Stations.Commands.Create;

public class CreateStationCommandValidator : AbstractValidator<CreateStationCommand>
{
    public CreateStationCommandValidator()
    {
        RuleFor(x => x.StationName).NotEmpty();
    }
}
