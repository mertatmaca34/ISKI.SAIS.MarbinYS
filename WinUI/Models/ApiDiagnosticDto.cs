using System;

namespace WinUI.Models;

public class ApiDiagnosticDto
{
    public DateTime? startDate { get; set; }
    public DateTime? endDate { get; set; }
    public Guid stationId { get; set; }
    public string details { get; set; } = string.Empty;
    public int? diagnosticTypeNo { get; set; }
}
