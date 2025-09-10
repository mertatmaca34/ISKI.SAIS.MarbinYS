using Microsoft.AspNetCore.Mvc;
using Infrastructure.Services.PLC;
using Microsoft.Extensions.Logging;

namespace Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class PlcDataController(IPlcDataCache dataCache, ILogger<PlcDataController> logger) : ControllerBase
{
    [HttpGet]
    public IActionResult GetLatest()
    {
        var data = dataCache.GetLatest();
        if (data == null)
        {
            logger.LogWarning("PLC data requested but cache is empty");
            return NotFound();
        }

        return Ok(data);
    }
}
