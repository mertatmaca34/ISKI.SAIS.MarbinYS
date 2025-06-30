using Application.Features.MailSettings.Commands.Create;
using Application.Features.MailSettings.Commands.Delete;
using Application.Features.MailSettings.Commands.Update;
using Application.Features.MailSettings.Queries.GetList;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class MailSettingsController(IMediator mediator) : ControllerBase
{
    [HttpPost]
    public async Task<IActionResult> Create(CreateMailSettingsCommand command)
    {
        var result = await mediator.Send(command);
        return Ok(result);
    }

    [HttpGet]
    public async Task<IActionResult> GetList()
    {
        var result = await mediator.Send(new GetMailSettingsQuery());
        return Ok(result);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> Update(int id, UpdateMailSettingsCommand command)
    {
        if (id != command.Id)
            return BadRequest();
        var result = await mediator.Send(command);
        return Ok(result);
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(int id)
    {
        var success = await mediator.Send(new DeleteMailSettingsCommand(id));
        if (!success)
            return NotFound();
        return NoContent();
    }
}
