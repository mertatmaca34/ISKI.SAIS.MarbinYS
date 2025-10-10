using System;
using System.Text.Json;
using WinUI.Models;

namespace WinUI.Services;

public interface ILogEntryParser
{
    bool TryParse(string logLine, out LogDto? logEntry);
}

public sealed class SerilogLogEntryParser : ILogEntryParser
{
    public bool TryParse(string logLine, out LogDto? logEntry)
    {
        logEntry = null;

        if (string.IsNullOrWhiteSpace(logLine))
        {
            return false;
        }

        try
        {
            using JsonDocument document = JsonDocument.Parse(logLine);
            JsonElement root = document.RootElement;

            if (!root.TryGetProperty("Timestamp", out JsonElement timestampElement))
            {
                return false;
            }

            DateTimeOffset timestamp;
            switch (timestampElement.ValueKind)
            {
                case JsonValueKind.String when DateTimeOffset.TryParse(timestampElement.GetString(), out var dto):
                    timestamp = dto;
                    break;
                default:
                    return false;
            }

            string level = root.TryGetProperty("Level", out JsonElement levelElement)
                ? levelElement.GetString() ?? string.Empty
                : string.Empty;

            string message = root.TryGetProperty("RenderedMessage", out JsonElement renderedMessage)
                ? renderedMessage.GetString() ?? string.Empty
                : root.TryGetProperty("MessageTemplate", out JsonElement template)
                    ? template.GetString() ?? string.Empty
                    : string.Empty;

            string? exception = root.TryGetProperty("Exception", out JsonElement exceptionElement)
                ? exceptionElement.GetString()
                : null;

            logEntry = new LogDto
            {
                LoggedAt = timestamp.LocalDateTime,
                Level = level,
                Message = message,
                Exception = string.IsNullOrWhiteSpace(exception) ? null : exception
            };

            return true;
        }
        catch (JsonException)
        {
            return false;
        }
    }
}
