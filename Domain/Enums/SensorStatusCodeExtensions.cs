using System.Collections.Generic;
using System.Linq;

namespace Domain.Enums;

/// <summary>
/// Helper methods for <see cref="SensorStatusCode"/>.
/// </summary>
public static class SensorStatusCodeExtensions
{
    private static readonly SensorStatusCode[] PriorityOrder = new[]
    {
        SensorStatusCode.Purge,
        SensorStatusCode.Yikama,
        SensorStatusCode.HaftalikYikama,
        SensorStatusCode.DebiArizasi
    };

    /// <summary>
    /// Returns the highest priority code from the given collection.
    /// </summary>
    public static SensorStatusCode GetPriorityCode(IEnumerable<SensorStatusCode> codes)
    {
        foreach (var priority in PriorityOrder)
        {
            if (codes.Contains(priority))
                return priority;
        }

        return codes.FirstOrDefault();
    }
}
