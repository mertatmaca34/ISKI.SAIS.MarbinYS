using System.Collections.Generic;
using Application.Features.DigitalSensorDatas.Constants;
namespace Application.Features.DigitalSensorDatas.Rules;

public static class DigitalSensorDataBusinessRules
{
    public static void EntityShouldNotBeNull(object? entity)
    {
        if (entity is null)
            throw new KeyNotFoundException(DigitalSensorDataMessages.NotFound);
    }
}
