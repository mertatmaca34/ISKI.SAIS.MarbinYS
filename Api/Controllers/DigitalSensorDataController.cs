using Application.Features.DigitalSensorDatas.Commands.Delete;
using Application.Features.DigitalSensorDatas.Queries.GetList;
using Application.Features.DigitalSensorDatas.Queries.GetById;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Application.Features.DigitalSensorDatas.Commands.Update;
using Application.Features.DigitalSensorDatas.Commands.Create;

namespace Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class DigitalSensorDataController(IMediator mediator) : ControllerBase
{
    [HttpPost]
    public async Task<IActionResult> Create(CreateDigitalSensorDataCommand command)
    {
        var result = await mediator.Send(command);
        return Ok(result);
    }

    [HttpGet]
    public async Task<IActionResult> GetList()
    {
        var result = await mediator.Send(new GetDigitalSensorDataQuery());
        return Ok(result);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(int id)
    {
        var result = await mediator.Send(new GetDigitalSensorDataByIdQuery(id));
        if (result is null)
            return NotFound();
        return Ok(result);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> Update(int id, UpdateDigitalSensorDataCommand command)
    {
        if (id != command.Id)
            return BadRequest();
        var result = await mediator.Send(command);
        return Ok(result);
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(int id)
    {
        var success = await mediator.Send(new DeleteDigitalSensorDataCommand(id));
        if (!success)
            return NotFound();
        return NoContent();
    }
}
