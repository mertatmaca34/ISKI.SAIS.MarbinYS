using Domain.Entities;

namespace Infrastructure.Services.PLC;

/// <summary>
/// Provides thread-safe access to the latest PLC data in memory.
/// </summary>
public interface IPlcDataCache
{
    /// <summary>
    /// Returns the most recently read PLC data, or <c>null</c> if no data is available.
    /// </summary>
    PlcData? GetLatest();

    /// <summary>
    /// Updates the cached PLC data.
    /// </summary>
    /// <param name="data">The data to cache.</param>
    void Update(PlcData data);
}

