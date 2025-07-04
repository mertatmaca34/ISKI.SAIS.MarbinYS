using System.Collections.Generic;
using Application.Features.CalibrationLimits.Constants;
namespace Application.Features.CalibrationLimits.Rules;

public static class CalibrationLimitBusinessRules
{
    public static void EntityShouldNotBeNull(object? entity)
    {
        if (entity is null)
            throw new KeyNotFoundException(CalibrationLimitMessages.NotFound);
    }
}
