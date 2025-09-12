using Microsoft.AspNetCore.Mvc;
using Infrastructure.Services.PLC;
using Application.Features.PlcData.Dtos;
using AutoMapper;
using Microsoft.Extensions.Logging;

namespace Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class PlcDataController(IPlcDataCache dataCache, IMapper mapper, ILogger<PlcDataController> logger) : ControllerBase
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

        var dto = mapper.Map<PlcDataDto>(data);
        return Ok(dto);
    }
}
