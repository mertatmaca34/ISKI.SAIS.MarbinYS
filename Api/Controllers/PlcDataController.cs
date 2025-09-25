using Microsoft.AspNetCore.Mvc;
using Infrastructure.Services.PLC;
using Application.Features.PlcData.Dtos;
using Api.Constants;
using AutoMapper;
using Application.Services.PlcData;
using Microsoft.Extensions.Logging;

namespace Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class PlcDataController(
    IPlcDataCache dataCache,
    IMapper mapper,
    ILogger<PlcDataController> logger,
    IAnalogSensorStatisticsService statisticsService) : ControllerBase
{
    [HttpGet]
    public async Task<IActionResult> GetLatest(CancellationToken cancellationToken)
    {
        var data = dataCache.GetLatest();
        if (data == null)
        {
            logger.LogWarning(LogMessages.PlcDataController.CacheEmpty);
            return NotFound();
        }

        var dto = mapper.Map<PlcDataDto>(data);
        dto.AnalogHourlyAverage = await statisticsService.GetHourlyAverageAsync(DateTime.Now, cancellationToken);
        return Ok(dto);
    }
}
