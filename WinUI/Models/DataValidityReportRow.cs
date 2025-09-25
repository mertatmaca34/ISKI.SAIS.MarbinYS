using System;

namespace WinUI.Models;

public class DataValidityReportRow
{
    public DateTime ReadTime { get; init; }
    public double? AKM { get; init; }
    public double? Debi { get; init; }
    public double? KOi { get; init; }
    public double? PH { get; init; }
    public double? Iletkenlik { get; init; }
    public double? AkisHizi { get; init; }
    public bool HasData { get; init; }
    public bool IsValid { get; init; }
    public string StatusDescription { get; init; } = string.Empty;
}
