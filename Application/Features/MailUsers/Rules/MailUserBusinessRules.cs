using System.Collections.Generic;
using Application.Features.MailUsers.Constants;
namespace Application.Features.MailUsers.Rules;

public static class MailUserBusinessRules
{
    public static void EntityShouldNotBeNull(object? entity)
    {
        if (entity is null)
            throw new KeyNotFoundException(MailUserMessages.NotFound);
    }
}
