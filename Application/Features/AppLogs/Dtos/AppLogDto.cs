using Domain.Enums;

namespace Application.Features.AppLogs.Dtos;

public class AppLogDto
{
    public int Id { get; set; }
    public LogLevel Level { get; set; }
    public string Message { get; set; } = string.Empty;
    public string? Exception { get; set; }
    public DateTime LoggedAt { get; set; }
}
