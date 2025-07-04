using System.Collections.Generic;
using Application.Features.MailTriggerRecipients.Constants;
namespace Application.Features.MailTriggerRecipients.Rules;

public static class MailTriggerRecipientBusinessRules
{
    public static void EntityShouldNotBeNull(object? entity)
    {
        if (entity is null)
            throw new KeyNotFoundException(MailTriggerRecipientMessages.NotFound);
    }
}
