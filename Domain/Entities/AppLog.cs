using System;
using ISKI.Core.Domain;
using Domain.Enums;

namespace Domain.Entities;

public class AppLog : BaseEntity<int>
{
    public LogLevel Level { get; set; }
    public string Message { get; set; }
    public string? Exception { get; set; }
    public DateTime LoggedAt { get; set; }
}
