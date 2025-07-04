using System.Collections.Generic;
using Application.Features.ApiEndpoints.Constants;
namespace Application.Features.ApiEndpoints.Rules;

public static class ApiEndpointBusinessRules
{
    public static void EntityShouldNotBeNull(object? entity)
    {
        if (entity is null)
            throw new KeyNotFoundException(ApiEndpointMessages.NotFound);
    }
}
