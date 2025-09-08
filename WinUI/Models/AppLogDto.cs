using Domain.Enums;

namespace WinUI.Models;

public class AppLogDto
{
    public int Id { get; set; }
    public LogLevel Level { get; set; }
    public string Message { get; set; } = string.Empty;
    public string? Exception { get; set; }
    public DateTime LoggedAt { get; set; }
}
