using System;
using System.Globalization;
using System.IO;
using System.Text.Json;
using Api.Constants;
using Api.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class LogsController : ControllerBase
{
    [HttpGet]
    public async Task<ActionResult<List<LogDto>>> GetList(
        [FromQuery] DateTime? startDate,
        [FromQuery] DateTime? endDate,
        [FromQuery] bool descending = false)
    {
        var start = startDate.HasValue ? new DateTimeOffset(startDate.Value) : DateTimeOffset.MinValue;
        var end = endDate.HasValue ? new DateTimeOffset(endDate.Value) : DateTimeOffset.MaxValue;

        var tempDirectory = Path.GetTempPath();
        var logDirectory = Path.Combine(tempDirectory, LogsConstants.ApplicationFolderName, LogsConstants.DirectoryName);

        if (!Directory.Exists(logDirectory))
        {
            return Ok(new List<LogDto>());
        }

        var searchPattern = string.Concat(LogsConstants.FilePrefix, "*", LogsConstants.FileExtension);
        var files = Directory.EnumerateFiles(logDirectory, searchPattern, SearchOption.TopDirectoryOnly)
            .OrderBy(f => f)
            .ToList();

        var records = new List<LogRecord>();
        long sequence = 0;

        foreach (var file in files)
        {
            try
            {
                await using var stream = new FileStream(file, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
                using var reader = new StreamReader(stream);

                string? line;
                while ((line = await reader.ReadLineAsync()) != null)
                {
                    if (string.IsNullOrWhiteSpace(line))
                    {
                        continue;
                    }

                    ParsedLog? parsed = ParseLogLine(line);

                    if (parsed is null)
                    {
                        continue;
                    }

                    if (parsed.Timestamp < start || parsed.Timestamp > end)
                    {
                        continue;
                    }

                    records.Add(new LogRecord(parsed.Timestamp, parsed.Level, parsed.Message, parsed.Exception, sequence++));
                }
            }
            catch (IOException)
            {
                // Skip files that are not accessible at the moment (e.g., being written to).
            }
            catch (UnauthorizedAccessException)
            {
                // Skip files that are not accessible at the moment (e.g., being written to).
            }
        }

        IEnumerable<LogRecord> ordered = descending
            ? records.OrderByDescending(r => r.Timestamp).ThenByDescending(r => r.Sequence)
            : records.OrderBy(r => r.Timestamp).ThenBy(r => r.Sequence);

        var result = ordered
            .Select((record, index) => new LogDto
            {
                Id = index + 1,
                Level = record.Level,
                Message = record.Message,
                Exception = record.Exception,
                LoggedAt = record.Timestamp.LocalDateTime
            })
            .ToList();

        return Ok(result);
    }

    private static ParsedLog? ParseLogLine(string line)
    {
        try
        {
            using JsonDocument document = JsonDocument.Parse(line);
            JsonElement root = document.RootElement;

            if (!root.TryGetProperty("Timestamp", out JsonElement timestampElement)
                || timestampElement.ValueKind != JsonValueKind.String)
            {
                return null;
            }

            string? timestampRaw = timestampElement.GetString();

            if (string.IsNullOrWhiteSpace(timestampRaw)
                || !DateTimeOffset.TryParse(timestampRaw, CultureInfo.InvariantCulture,
                    DateTimeStyles.RoundtripKind, out var timestamp))
            {
                return null;
            }

            string level = root.TryGetProperty("Level", out JsonElement levelElement)
                ? levelElement.GetString() ?? string.Empty
                : string.Empty;

            string message = root.TryGetProperty("RenderedMessage", out JsonElement renderedMessageElement)
                ? renderedMessageElement.GetString() ?? string.Empty
                : root.TryGetProperty("MessageTemplate", out JsonElement templateElement)
                    ? templateElement.GetString() ?? string.Empty
                    : string.Empty;

            string? exception = root.TryGetProperty("Exception", out JsonElement exceptionElement)
                && exceptionElement.ValueKind == JsonValueKind.String
                ? exceptionElement.GetString()
                : null;

            exception = string.IsNullOrWhiteSpace(exception) ? null : exception;

            return new ParsedLog(timestamp, level, message, exception);
        }
        catch (JsonException)
        {
            return null;
        }
    }

    private sealed record ParsedLog(DateTimeOffset Timestamp, string Level, string Message, string? Exception);

    private sealed record LogRecord(DateTimeOffset Timestamp, string Level, string Message, string? Exception, long Sequence);
}
