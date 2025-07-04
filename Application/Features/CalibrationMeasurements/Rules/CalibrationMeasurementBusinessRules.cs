using System.Collections.Generic;
using Application.Features.CalibrationMeasurements.Constants;
namespace Application.Features.CalibrationMeasurements.Rules;

public static class CalibrationMeasurementBusinessRules
{
    public static void EntityShouldNotBeNull(object? entity)
    {
        if (entity is null)
            throw new KeyNotFoundException(CalibrationMeasurementMessages.NotFound);
    }
}
