using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
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
    private readonly HttpClient _httpClient;
    private readonly ILogFileLocator _fileLocator;
    private readonly ILogEntryParser _parser;
    private readonly ILogger<LogService> _logger;
    private static readonly JsonSerializerOptions SerializerOptions = new(JsonSerializerDefaults.Web);

    public LogService(HttpClient httpClient, ILogFileLocator fileLocator, ILogEntryParser parser, ILogger<LogService> logger)
    {
        _httpClient = httpClient ?? throw new ArgumentNullException(nameof(httpClient));
        _fileLocator = fileLocator ?? throw new ArgumentNullException(nameof(fileLocator));
        _parser = parser ?? throw new ArgumentNullException(nameof(parser));
        _logger = logger ?? throw new ArgumentNullException(nameof(logger));
    }

    public async Task<List<LogDto>> GetAsync(DateTime startDate, DateTime endDate, bool descending)
    {
        if (endDate <= startDate)
        {
            return new List<LogDto>();
        }

        List<LogDto>? remoteLogs = await TryGetFromApiAsync(startDate, endDate, descending);
        if (remoteLogs != null)
        {
            return SortAndRenumber(FilterByRange(remoteLogs, startDate, endDate), descending);
        }

        return SortAndRenumber(ReadFromFileSystem(startDate, endDate), descending);
    }

    private async Task<List<LogDto>?> TryGetFromApiAsync(DateTime startDate, DateTime endDate, bool descending)
    {
        try
        {
            string requestUri = BuildRequestUri(startDate, endDate, descending);
            using HttpResponseMessage response = await _httpClient.GetAsync(requestUri);

            if (!response.IsSuccessStatusCode)
            {
                _logger.LogWarning(
                    "Log kayıtları API'den alınamadı. StatusCode: {StatusCode}",
                    response.StatusCode);
                return null;
            }

            var logs = await response.Content.ReadFromJsonAsync<List<LogDto>>(SerializerOptions);
            return logs ?? new List<LogDto>();
        }
        catch (HttpRequestException ex)
        {
            _logger.LogWarning(ex, "Log kayıtları API'den alınırken hata oluştu. Yerel log dosyaları kullanılacak.");
            return null;
        }
        catch (TaskCanceledException ex) when (!ex.CancellationToken.IsCancellationRequested)
        {
            _logger.LogWarning(ex, "Log kayıtları API'den alınırken zaman aşımı oluştu. Yerel log dosyaları kullanılacak.");
            return null;
        }
        catch (NotSupportedException ex)
        {
            _logger.LogWarning(ex, "Log kayıtları API yanıtı desteklenmeyen bir biçimde." );
            return null;
        }
        catch (JsonException ex)
        {
            _logger.LogWarning(ex, "Log kayıtları API yanıtı ayrıştırılamadı. Yerel log dosyaları kullanılacak.");
            return null;
        }
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

    private static IEnumerable<LogDto> FilterByRange(IEnumerable<LogDto> entries, DateTime startDate, DateTime endDate) =>
        entries.Where(log => log.LoggedAt >= startDate && log.LoggedAt < endDate);

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

    private static string BuildRequestUri(DateTime startDate, DateTime endDate, bool descending)
    {
        var builder = new StringBuilder("api/logs?");
        builder.Append("startDate=");
        builder.Append(Uri.EscapeDataString(startDate.ToString("o")));
        builder.Append("&endDate=");
        builder.Append(Uri.EscapeDataString(endDate.ToString("o")));
        builder.Append("&descending=");
        builder.Append(descending ? "true" : "false");
        return builder.ToString();
    }
}
