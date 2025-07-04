using System.Collections.Generic;
using Application.Features.AnalogSensorDatas.Constants;
namespace Application.Features.AnalogSensorDatas.Rules;

public static class AnalogSensorDataBusinessRules
{
    public static void EntityShouldNotBeNull(object? entity)
    {
        if (entity is null)
            throw new KeyNotFoundException(AnalogSensorDataMessages.NotFound);
    }
}
