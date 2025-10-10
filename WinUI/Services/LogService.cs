using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using WinUI.Models;

namespace WinUI.Services;

public interface ILogService
{
    Task<List<LogDto>> GetAsync(DateTime startDate, DateTime endDate, bool descending);
}

public class LogService : ILogService
{
    private readonly ILogFileLocator _fileLocator;
    private readonly ILogEntryParser _parser;
    private readonly ILogger<LogService> _logger;

    public LogService(ILogFileLocator fileLocator, ILogEntryParser parser, ILogger<LogService> logger)
    {
        _fileLocator = fileLocator ?? throw new ArgumentNullException(nameof(fileLocator));
        _parser = parser ?? throw new ArgumentNullException(nameof(parser));
        _logger = logger ?? throw new ArgumentNullException(nameof(logger));
    }

    public Task<List<LogDto>> GetAsync(DateTime startDate, DateTime endDate, bool descending)
    {
        if (endDate <= startDate)
        {
            return Task.FromResult(new List<LogDto>());
        }

        var entries = new List<LogDto>();
        foreach (string filePath in _fileLocator.GetFiles(startDate, endDate))
        {
            try
            {
                foreach (string line in File.ReadLines(filePath))
                {
                    if (!_parser.TryParse(line, out LogDto? logEntry) || logEntry == null)
                    {
                        continue;
                    }

                    if (logEntry.LoggedAt < startDate || logEntry.LoggedAt >= endDate)
                    {
                        continue;
                    }

                    logEntry.Id = entries.Count + 1;
                    entries.Add(logEntry);
                }
            }
            catch (IOException ex)
            {
                _logger.LogWarning(ex, "Log dosyası okunamadı: {FilePath}", filePath);
            }
            catch (UnauthorizedAccessException ex)
            {
                _logger.LogWarning(ex, "Log dosyasına erişilemiyor: {FilePath}", filePath);
            }
        }

        var ordered = descending
            ? entries.OrderByDescending(x => x.LoggedAt).ThenByDescending(x => x.Id).ToList()
            : entries.OrderBy(x => x.LoggedAt).ThenBy(x => x.Id).ToList();

        for (int index = 0; index < ordered.Count; index++)
        {
            ordered[index].Id = index + 1;
        }

        return Task.FromResult(ordered);
    }
}
