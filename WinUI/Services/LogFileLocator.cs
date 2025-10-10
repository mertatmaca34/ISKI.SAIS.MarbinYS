using System;
using System.Collections.Generic;
using System.IO;

namespace WinUI.Services;

public interface ILogFileLocator
{
    IEnumerable<string> GetFiles(DateTime startDate, DateTime endDate);
}

public sealed class DailyLogFileLocator : ILogFileLocator
{
    private readonly string _directoryPath;
    private readonly string _filePrefix;
    private readonly string _fileExtension;

    public DailyLogFileLocator(string directoryPath, string filePrefix, string fileExtension)
    {
        _directoryPath = directoryPath ?? throw new ArgumentNullException(nameof(directoryPath));
        _filePrefix = filePrefix ?? throw new ArgumentNullException(nameof(filePrefix));
        _fileExtension = fileExtension ?? throw new ArgumentNullException(nameof(fileExtension));
    }

    public IEnumerable<string> GetFiles(DateTime startDate, DateTime endDate)
    {
        if (endDate < startDate)
        {
            yield break;
        }

        DateTime current = startDate.Date;
        DateTime last = endDate.Date;

        var seen = new HashSet<string>(StringComparer.OrdinalIgnoreCase);
        while (current <= last)
        {
            string fileName = $"{_filePrefix}{current:yyyyMMdd}{_fileExtension}";
            string filePath = Path.Combine(_directoryPath, fileName);

            if (File.Exists(filePath) && seen.Add(filePath))
            {
                yield return filePath;
            }

            current = current.AddDays(1);
        }
    }
}
