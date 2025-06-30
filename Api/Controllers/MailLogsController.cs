using Application.Features.MailLogs.Queries.GetList;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class MailLogsController(IMediator mediator) : ControllerBase
{
    [HttpGet]
    public async Task<IActionResult> GetList()
    {
        var result = await mediator.Send(new GetMailLogsQuery());
        return Ok(result);
    }
}
