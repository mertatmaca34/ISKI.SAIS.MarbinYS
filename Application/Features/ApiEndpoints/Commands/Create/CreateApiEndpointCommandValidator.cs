using FluentValidation;

namespace Application.Features.ApiEndpoints.Commands.Create;

public class CreateApiEndpointCommandValidator : AbstractValidator<CreateApiEndpointCommand>
{
    public CreateApiEndpointCommandValidator()
    {
        RuleFor(x => x.ApiAddress).NotEmpty();
        RuleFor(x => x.UserName).NotEmpty();
        RuleFor(x => x.Password).NotEmpty();
    }
}
