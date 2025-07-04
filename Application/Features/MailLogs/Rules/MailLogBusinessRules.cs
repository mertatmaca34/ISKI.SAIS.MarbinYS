using System.Collections.Generic;
using Application.Features.MailLogs.Constants;
namespace Application.Features.MailLogs.Rules;

public static class MailLogBusinessRules
{
    public static void EntityShouldNotBeNull(object? entity)
    {
        if (entity is null)
            throw new KeyNotFoundException(MailLogMessages.NotFound);
    }
}
