using System.Collections.Generic;
using Application.Features.PlcInformations.Constants;
namespace Application.Features.PlcInformations.Rules;

public static class PlcInformationBusinessRules
{
    public static void EntityShouldNotBeNull(object? entity)
    {
        if (entity is null)
            throw new KeyNotFoundException(PlcInformationMessages.NotFound);
    }
}
