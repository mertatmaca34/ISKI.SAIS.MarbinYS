using System.Linq;
using FluentValidation;
using Microsoft.Extensions.Options;

namespace Infrastructure.Remote.SAIS.Configuration;

internal sealed class FluentValidationOptions<TOptions> : IValidateOptions<TOptions>
    where TOptions : class
{
    private readonly IValidator<TOptions> _validator;

    public FluentValidationOptions(IValidator<TOptions> validator)
    {
        _validator = validator;
    }

    public ValidateOptionsResult Validate(string? name, TOptions options)
    {
        ArgumentNullException.ThrowIfNull(options);

        var validationResult = _validator.Validate(options);
        return validationResult.IsValid
            ? ValidateOptionsResult.Success
            : ValidateOptionsResult.Fail(validationResult.Errors.Select(error => error.ErrorMessage));
    }
}
