using Application.Features.MailAlarms.Commands.UpdateUser;
using Application.Features.MailAlarms.Commands.Update;
using Application.Features.MailAlarms.Queries.GetList;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class MailAlarmsController(IMediator mediator) : ControllerBase
{
    [HttpGet("{userId}")]
    public async Task<IActionResult> GetList(int userId)
    {
        var result = await mediator.Send(new GetMailAlarmsQuery(userId));
        return Ok(result);
    }

    [HttpPost("{userId}")]
    public async Task<IActionResult> Update(int userId, [FromBody] List<int> alarmIds)
    {
        await mediator.Send(new UpdateUserMailAlarmsCommand(userId, alarmIds));
        return NoContent();
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> UpdateAlarm(int id, [FromBody] UpdateMailAlarmCommand command)
    {
        if (id != command.Id)
            return BadRequest();
        var result = await mediator.Send(command);
        return Ok(result);
    }
}

