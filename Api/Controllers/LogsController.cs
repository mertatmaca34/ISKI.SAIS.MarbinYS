using Api.Dtos;
using Infrastructure.Persistence;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class LogsController(IBKSContext context) : ControllerBase
{
    [HttpGet]
    public async Task<ActionResult<List<LogDto>>> GetList(
        [FromQuery] DateTime? startDate,
        [FromQuery] DateTime? endDate,
        [FromQuery] bool descending = false)
    {
        DateTime start = startDate ?? DateTime.MinValue;
        DateTime end = endDate ?? DateTime.MaxValue;

        var query = context.Logs.AsNoTracking()
            .Where(l => l.TimeStamp >= start && l.TimeStamp <= end);

        query = descending ? query.OrderByDescending(l => l.TimeStamp) : query.OrderBy(l => l.TimeStamp);

        var logs = await query
            .Select(l => new LogDto
            {
                Id = l.Id,
                Level = l.Level,
                Message = l.Message,
                Exception = l.Exception,
                LoggedAt = l.TimeStamp
            }).ToListAsync();

        return Ok(logs);
    }
}
