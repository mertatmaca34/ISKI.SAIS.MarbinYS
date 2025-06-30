using Application.Features.MailTriggerRecipients.Commands.Create;
using Application.Features.MailTriggerRecipients.Commands.Delete;
using Application.Features.MailTriggerRecipients.Queries.GetList;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class MailTriggerRecipientsController(IMediator mediator) : ControllerBase
{
    [HttpPost]
    public async Task<IActionResult> Create(CreateMailTriggerRecipientCommand command)
    {
        var result = await mediator.Send(command);
        return Ok(result);
    }

    [HttpGet]
    public async Task<IActionResult> GetList()
    {
        var result = await mediator.Send(new GetMailTriggerRecipientsQuery());
        return Ok(result);
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(int id)
    {
        var success = await mediator.Send(new DeleteMailTriggerRecipientCommand(id));
        if (!success)
            return NotFound();
        return NoContent();
    }
}
