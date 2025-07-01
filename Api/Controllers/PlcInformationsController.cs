using Application.Features.PlcInformations.Commands.Create;
using Application.Features.PlcInformations.Commands.Delete;
using Application.Features.PlcInformations.Commands.Update;
using Application.Features.PlcInformations.Queries.GetList;
using Application.Features.PlcInformations.Queries.GetById;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class PlcInformationsController(IMediator mediator) : ControllerBase
{
    [HttpPost]
    public async Task<IActionResult> Create(CreatePlcInformationCommand command)
    {
        var result = await mediator.Send(command);
        return Ok(result);
    }

    [HttpGet]
    public async Task<IActionResult> GetList()
    {
        var result = await mediator.Send(new GetPlcInformationsQuery());
        return Ok(result);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(int id)
    {
        var result = await mediator.Send(new GetPlcInformationByIdQuery(id));
        if (result is null)
            return NotFound();
        return Ok(result);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> Update(int id, UpdatePlcInformationCommand command)
    {
        if (id != command.Id)
            return BadRequest();
        var result = await mediator.Send(command);
        return Ok(result);
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(int id)
    {
        var success = await mediator.Send(new DeletePlcInformationCommand(id));
        if (!success)
            return NotFound();
        return NoContent();
    }
}
