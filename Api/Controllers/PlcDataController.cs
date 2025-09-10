using Application.Features.PlcData.Commands.ReadAndSavePlcData;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class PlcDataController(IMediator mediator, IConfiguration configuration) : ControllerBase
{
    [HttpPost("read")]
    public async Task<IActionResult> ReadAndSave()
    {
        var ipAddress = configuration["PlcSettings:IpAddress"];
        if (string.IsNullOrWhiteSpace(ipAddress))
        {
            return NotFound();
        }

        var cmd = new ReadAndSavePlcDataCommand(
            ipAddress,
            configuration.GetValue<int>("PlcSettings:AnalogDb"),
            configuration.GetValue<int>("PlcSettings:AnalogStart"),
            configuration.GetValue<int>("PlcSettings:AnalogLength"),
            configuration.GetValue<int>("PlcSettings:DigitalDb"),
            configuration.GetValue<int>("PlcSettings:DigitalStart"),
            configuration.GetValue<int>("PlcSettings:DigitalLength"),
            configuration.GetValue<int>("PlcSettings:TimeParameterDb"),
            configuration.GetValue<int>("PlcSettings:TimeParameterStart"),
            configuration.GetValue<int>("PlcSettings:TimeParameterLength"));

        try
        {
            var result = await mediator.Send(cmd);
            return Ok(result);
        }
        catch (Exception ex)
        {
            return StatusCode(500, new { Message = ex.Message });
        }
    }
}
