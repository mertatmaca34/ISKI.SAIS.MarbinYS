using FluentValidation;

namespace Application.Features.ApiEndpoints.Commands.Update;

public class UpdateApiEndpointCommandValidator : AbstractValidator<UpdateApiEndpointCommand>
{
    public UpdateApiEndpointCommandValidator()
    {
        RuleFor(x => x.Id).GreaterThan(0);
        RuleFor(x => x.ApiAddress).NotEmpty();
        RuleFor(x => x.UserName).NotEmpty();
        RuleFor(x => x.Password).NotEmpty();
    }
}
