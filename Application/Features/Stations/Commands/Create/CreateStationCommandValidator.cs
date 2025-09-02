using FluentValidation;

namespace Application.Features.Stations.Commands.Create;

public class CreateStationCommandValidator : AbstractValidator<CreateStationCommand>
{
    public CreateStationCommandValidator()
    {
        RuleFor(x => x.Code).NotEmpty();
        RuleFor(x => x.Name).NotEmpty();
        RuleFor(x => x.DataPeriodMinute).GreaterThan(0);
    }
}
