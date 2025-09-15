using Application.Features.SendDatas.Queries.GetList;
using Application.Features.SendDatas.Queries.GetById;
using MediatR;                     
using Microsoft.AspNetCore.Mvc;
using Application.Features.SendDatas.Commands;
using Application.Features.SendDatas.Commands.Create;

namespace Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class SendDataController(IMediator mediator) : ControllerBase
{
    [HttpGet]
    public async Task<IActionResult> GetList()
    {
        var result = await mediator.Send(new GetSendDataQuery());
        return Ok(result);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(int id)
    {
        var result = await mediator.Send(new GetSendDataByIdQuery(id));
        if (result is null)
            return NotFound();
        return Ok(result);
    }
    [HttpPost]
    public async Task<IActionResult> Create(CreateSendDataCommand command)
    {
        var result = await mediator.Send(command);
        return Ok(result);
    }

    [HttpPost("send")]
    public async Task<IActionResult> Send(SendDataCommand command)
    {
        var result = await mediator.Send(command);
        return Ok(result);
    }
}
