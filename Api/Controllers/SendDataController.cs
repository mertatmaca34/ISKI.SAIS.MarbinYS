using System;
using Application.Features.SendDatas.Queries.GetList;
using Application.Features.SendDatas.Queries.GetById;
using Application.Features.SendDatas.Queries.GetByStationAndReadTime;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Application.Features.SendDatas.Commands;
using Application.Features.SendDatas.Commands.Create;
using Application.Features.SendDatas.Commands.Update;
using Application.Features.SendDatas.Queries.GetLatestReadTime;

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

    [HttpGet("latest-readtime")]
    public async Task<IActionResult> GetLatestReadTime()
    {
        var result = await mediator.Send(new GetLatestReadTimeQuery());
        if (result is null)
            return NotFound();

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

    [HttpGet("by-station-and-readtime")]
    public async Task<IActionResult> GetByStationAndReadTime([FromQuery] Guid stationId, [FromQuery] DateTime readTime)
    {
        var result = await mediator.Send(new GetSendDataByStationAndReadTimeQuery(stationId, readTime));
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

    [HttpPut("{id}/status")]
    public async Task<IActionResult> UpdateStatus(int id, UpdateSendDataStatusCommand command)
    {
        if (id != command.Id)
            return BadRequest();

        var result = await mediator.Send(command);
        if (result is null)
            return NotFound();

        return Ok(result);
    }

    [HttpPost("send")]
    public async Task<IActionResult> Send(SendDataCommand command)
    {
        var result = await mediator.Send(command);
        return Ok(result);
    }
}
