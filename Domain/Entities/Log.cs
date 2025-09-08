using System;

namespace Domain.Entities;

public class Log
{
    public int Id { get; set; }
    public string Level { get; set; } = string.Empty;
    public string Message { get; set; } = string.Empty;
    public string? Exception { get; set; }
    public DateTime TimeStamp { get; set; }
}
