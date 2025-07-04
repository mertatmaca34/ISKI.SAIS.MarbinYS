using System.Collections.Generic;
using Application.Features.SendDatas.Constants;
namespace Application.Features.SendDatas.Rules;

public static class SendDataBusinessRules
{
    public static void EntityShouldNotBeNull(object? entity)
    {
        if (entity is null)
            throw new KeyNotFoundException(SendDataMessages.NotFound);
    }
}
