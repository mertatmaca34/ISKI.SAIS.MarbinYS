using Application.Features.SendData.Commands;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class SendDataController(IMediator mediator) : ControllerBase
{
    [HttpPost]
    public async Task<IActionResult> Send(SendDataCommand command)
    {
        var result = await mediator.Send(command);
        return Ok(result);
    }
}
