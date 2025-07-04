using Application.Features.PlcData.Commands.ReadAndSavePlcData;
using Application.Features.PlcData.Queries.GetTimeParameters;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class PlcDataController(IMediator mediator, IConfiguration configuration) : ControllerBase
{
    [HttpGet("time-parameters")]
    public async Task<IActionResult> GetTimeParameters()
    {
        var query = new GetPlcTimeParametersQuery(
            configuration["PlcSettings:IpAddress"] ?? "10.33.3.253",
            configuration.GetValue<int>("PlcSettings:TimeDb"),
            configuration.GetValue<int>("PlcSettings:TimeStart"),
            configuration.GetValue<int>("PlcSettings:TimeLength"));

        try
        {
            var result = await mediator.Send(query);
            return Ok(result);
        }
        catch (Exception ex)
        {
            return StatusCode(500, new { Message = ex.Message });
        }
    }
    [HttpPost("read")]
    public async Task<IActionResult> ReadAndSave()
    {
        var cmd = new ReadAndSavePlcDataCommand(
            configuration["PlcSettings:IpAddress"] ?? "10.33.3.253",
            configuration.GetValue<int>("PlcSettings:AnalogDb"),
            configuration.GetValue<int>("PlcSettings:AnalogStart"),
            configuration.GetValue<int>("PlcSettings:AnalogLength"),
            configuration.GetValue<int>("PlcSettings:DigitalDb"),
            configuration.GetValue<int>("PlcSettings:DigitalStart"),
            configuration.GetValue<int>("PlcSettings:DigitalLength"));

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
