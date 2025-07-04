using System.Collections.Generic;
using Application.Features.MailTriggers.Constants;
namespace Application.Features.MailTriggers.Rules;

public static class MailTriggerBusinessRules
{
    public static void EntityShouldNotBeNull(object? entity)
    {
        if (entity is null)
            throw new KeyNotFoundException(MailTriggerMessages.NotFound);
    }
}
