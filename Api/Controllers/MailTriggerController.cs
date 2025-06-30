using Application.Features.MailTriggers.Commands.Create;
using Application.Features.MailTriggers.Queries.GetList;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class MailTriggerController(IMediator mediator) : ControllerBase
{
    [HttpPost]
    public async Task<IActionResult> Create(CreateMailTriggerCommand command)
    {
        var result = await mediator.Send(command);
        return Ok(result);
    }

    [HttpGet]
    public async Task<IActionResult> GetList()
    {
        var result = await mediator.Send(new GetMailTriggersQuery());
        return Ok(result);
    }
}
