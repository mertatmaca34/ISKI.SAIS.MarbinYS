using System.Collections.Generic;
using Application.Features.MailSettings.Constants;
namespace Application.Features.MailSettings.Rules;

public static class MailSettingBusinessRules
{
    public static void EntityShouldNotBeNull(object? entity)
    {
        if (entity is null)
            throw new KeyNotFoundException(MailSettingsMessages.NotFound);
    }
}
