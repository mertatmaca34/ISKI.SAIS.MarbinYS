using Application.Features.Users.Commands.Create;
using Application.Features.Users.Commands.Delete;
using Application.Features.Users.Commands.Update;
using Application.Features.Users.Queries.GetList;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class UsersController(IMediator mediator) : ControllerBase
{
    [HttpPost]
    public async Task<IActionResult> Create(CreateUserCommand command)
    {
        var result = await mediator.Send(command);
        return Ok(result);
    }

    [HttpGet]
    public async Task<IActionResult> GetList()
    {
        var result = await mediator.Send(new GetUsersQuery());
        return Ok(result);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> Update(int id, UpdateUserCommand command)
    {
        if (id != command.Id)
            return BadRequest();
        var result = await mediator.Send(command);
        return Ok(result);
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(int id)
    {
        var success = await mediator.Send(new DeleteUserCommand(id));
        if (!success)
            return NotFound();
        return NoContent();
    }
}

