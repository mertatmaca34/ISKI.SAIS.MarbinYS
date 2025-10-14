using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Abstractions;
using System.IO;
using System.Text;
using WinUI.Constants;
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

    public LogService(ILogFileLocator? fileLocator, ILogEntryParser? parser, ILogger<LogService>? logger = null)
    {
        _fileLocator = fileLocator ?? CreateDefaultLocator();
        _parser = parser ?? new SerilogLogEntryParser();
        _logger = logger ?? NullLogger<LogService>.Instance;
    }

    public Task<List<LogDto>> GetAsync(DateTime startDate, DateTime endDate, bool descending)
    {
        if (endDate <= startDate)
        {
            return Task.FromResult(new List<LogDto>());
        }

        var entries = ReadFromFileSystem(startDate, endDate);
        return Task.FromResult(SortAndRenumber(entries, descending));
    }

    private List<LogDto> ReadFromFileSystem(DateTime startDate, DateTime endDate)
    {
        var entries = new List<LogDto>();
        foreach (string filePath in _fileLocator.GetFiles(startDate, endDate))
        {
            try
            {
                foreach (string line in File.ReadLines(filePath, Encoding.UTF8))
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

        return entries;
    }

    private static List<LogDto> SortAndRenumber(IEnumerable<LogDto> entries, bool descending)
    {
        var ordered = descending
            ? entries.OrderByDescending(x => x.LoggedAt).ThenByDescending(x => x.Id).ToList()
            : entries.OrderBy(x => x.LoggedAt).ThenBy(x => x.Id).ToList();

        for (int index = 0; index < ordered.Count; index++)
        {
            ordered[index].Id = index + 1;
        }
        return ordered;
    }

    private static ILogFileLocator CreateDefaultLocator()
    {
        string tempDirectory = Path.GetTempPath();
        string logsDirectory = Path.Combine(tempDirectory, LogsConstants.ApplicationFolderName, LogsConstants.DirectoryName);
        Directory.CreateDirectory(logsDirectory);
        return new DailyLogFileLocator(logsDirectory, LogsConstants.FilePrefix, LogsConstants.FileExtension);
    }
}