using Application.Features.CalibrationMeasurements.Commands.Create;
using Application.Features.CalibrationMeasurements.Commands.Delete;
using Application.Features.CalibrationMeasurements.Commands.Update;
using Application.Features.CalibrationMeasurements.Queries.GetList;
using Application.Features.CalibrationMeasurements.Queries.GetById;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class CalibrationMeasurementsController(IMediator mediator) : ControllerBase
{
    [HttpPost]
    public async Task<IActionResult> Create(CreateCalibrationMeasurementCommand command)
    {
        var result = await mediator.Send(command);
        return Ok(result);
    }

    [HttpGet]
    public async Task<IActionResult> GetList()
    {
        var result = await mediator.Send(new GetCalibrationMeasurementsQuery());
        return Ok(result);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(int id)
    {
        var result = await mediator.Send(new GetCalibrationMeasurementByIdQuery(id));
        if (result is null)
            return NotFound();
        return Ok(result);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> Update(int id, UpdateCalibrationMeasurementCommand command)
    {
        if (id != command.Id)
            return BadRequest();
        var result = await mediator.Send(command);
        return Ok(result);
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(int id)
    {
        var success = await mediator.Send(new DeleteCalibrationMeasurementCommand(id));
        if (!success)
            return NotFound();
        return NoContent();
    }
}
