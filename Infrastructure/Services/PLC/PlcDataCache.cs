using System;
using Application.Features.PlcData.Dtos;
using Microsoft.Extensions.Logging;

namespace Infrastructure.Services.PLC;

/// <summary>
/// In-memory cache for PLC data that can be shared across the application.
/// </summary>
public class PlcDataCache : IPlcDataCache
{
    private readonly object _lock = new();
    private PlcDataDto? _current;
    private readonly ILogger<PlcDataCache> _logger;

    public PlcDataCache(ILogger<PlcDataCache> logger)
    {
        _logger = logger;
    }

    public PlcDataDto? GetLatest()
    {
        lock (_lock)
        {
            return _current;
        }
    }

    public void Update(PlcDataDto data)
    {
        if (data == null)
        {
            _logger.LogWarning("Attempted to cache null PLC data");
            return;
        }

        lock (_lock)
        {
            _current = data;
            _logger.LogInformation("PLC data cache updated at {Time}", DateTime.UtcNow);
        }
    }
}

