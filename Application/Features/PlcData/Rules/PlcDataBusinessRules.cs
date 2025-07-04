using System.Collections.Generic;
using Application.Features.PlcData.Constants;
namespace Application.Features.PlcData.Rules;

public static class PlcDataBusinessRules
{
    public static void EntityShouldNotBeNull(object? entity)
    {
        if (entity is null)
            throw new KeyNotFoundException(PlcDataMessages.NotFound);
    }
}
