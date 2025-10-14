using FluentValidation;

namespace Infrastructure.Remote.SAIS.Configuration;

public sealed class SaisApiOptionsValidator : AbstractValidator<SaisApiOptions>
{
    public SaisApiOptionsValidator()
    {
        RuleFor(x => x.BaseUrl)
            .NotEmpty();

        RuleFor(x => x.Username)
            .NotEmpty();

        RuleFor(x => x.PasswordHash)
            .NotEmpty();

        RuleFor(x => x.TicketRenewalOffset)
            .GreaterThan(TimeSpan.Zero);
    }
}
