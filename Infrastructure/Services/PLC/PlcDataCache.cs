using System;
using Domain.Entities;
using Infrastructure.Constants;
using Microsoft.Extensions.Logging;

namespace Infrastructure.Services.PLC;

/// <summary>
/// In-memory cache for PLC data that can be shared across the application.
/// </summary>
public class PlcDataCache : IPlcDataCache
{
    private readonly object _lock = new();
    private PlcData? _current;
    private readonly ILogger<PlcDataCache> _logger;

    public PlcDataCache(ILogger<PlcDataCache> logger)
    {
        _logger = logger;
    }

    public PlcData? GetLatest()
    {
        lock (_lock)
        {
            return _current;
        }
    }

    public void Update(PlcData data)
    {
        if (data == null)
        {
            _logger.LogWarning(LogMessages.PlcDataCache.NullDataAttempt);
            return;
        }

        lock (_lock)
        {
            _current = data;
            _logger.LogInformation(LogMessages.PlcDataCache.CacheUpdated, DateTime.UtcNow);
        }
    }
}

