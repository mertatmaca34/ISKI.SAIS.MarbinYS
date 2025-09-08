using Application.Features.AppLogs.Queries.GetList;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class AppLogsController(IMediator mediator) : ControllerBase
{
    [HttpGet]
    public async Task<IActionResult> GetList([FromQuery] DateTime? startDate, [FromQuery] DateTime? endDate, [FromQuery] bool descending = false)
    {
        var result = await mediator.Send(new GetAppLogsQuery(startDate, endDate, descending));
        return Ok(result);
    }
}
