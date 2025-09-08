using Api.Dtos;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using System.Collections.Generic;

namespace Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class LogsController(IConfiguration configuration) : ControllerBase
{
    private readonly string _connectionString = configuration.GetConnectionString("Default") ?? string.Empty;

    [HttpGet]
    public async Task<ActionResult<List<LogDto>>> GetList([FromQuery] DateTime? startDate, [FromQuery] DateTime? endDate, [FromQuery] bool descending = false)
    {
        DateTime start = startDate ?? DateTime.MinValue;
        DateTime end = endDate ?? DateTime.MaxValue;
        List<LogDto> logs = new();

        await using var connection = new SqlConnection(_connectionString);
        await connection.OpenAsync();

        string orderBy = descending ? "DESC" : "ASC";
        string query = $"SELECT Id, Level, Message, Exception, TimeStamp FROM Logs WHERE TimeStamp BETWEEN @Start AND @End ORDER BY TimeStamp {orderBy}";

        await using var command = new SqlCommand(query, connection);
        command.Parameters.AddWithValue("@Start", start);
        command.Parameters.AddWithValue("@End", end);

        await using var reader = await command.ExecuteReaderAsync();
        while (await reader.ReadAsync())
        {
            logs.Add(new LogDto
            {
                Id = reader.GetInt32(0),
                Level = reader.GetString(1),
                Message = reader.GetString(2),
                Exception = reader.IsDBNull(3) ? null : reader.GetString(3),
                LoggedAt = reader.GetDateTime(4)
            });
        }

        return Ok(logs);
    }
}
