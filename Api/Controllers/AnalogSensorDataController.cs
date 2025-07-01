using Application.Features.AnalogSensorData.Commands.Create;
using Application.Features.AnalogSensorData.Commands.Delete;
using Application.Features.AnalogSensorData.Commands.Update;
using Application.Features.AnalogSensorData.Queries.GetList;
using Application.Features.AnalogSensorData.Queries.GetById;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class AnalogSensorDataController(IMediator mediator) : ControllerBase
{
    [HttpPost]
    public async Task<IActionResult> Create(CreateAnalogSensorDataCommand command)
    {
        var result = await mediator.Send(command);
        return Ok(result);
    }

    [HttpGet]
    public async Task<IActionResult> GetList()
    {
        var result = await mediator.Send(new GetAnalogSensorDataQuery());
        return Ok(result);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(int id)
    {
        var result = await mediator.Send(new GetAnalogSensorDataByIdQuery(id));
        if (result is null)
            return NotFound();
        return Ok(result);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> Update(int id, UpdateAnalogSensorDataCommand command)
    {
        if (id != command.Id)
            return BadRequest();
        var result = await mediator.Send(command);
        return Ok(result);
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(int id)
    {
        var success = await mediator.Send(new DeleteAnalogSensorDataCommand(id));
        if (!success)
            return NotFound();
        return NoContent();
    }
}
