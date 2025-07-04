using System.Collections.Generic;
using Application.Features.Stations.Constants;
namespace Application.Features.Stations.Rules;

public static class StationBusinessRules
{
    public static void EntityShouldNotBeNull(object? entity)
    {
        if (entity is null)
            throw new KeyNotFoundException(StationMessages.NotFound);
    }
}
