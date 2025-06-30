namespace ISKI.Core.Persistence.Dynamic;

public class FilterOption
{
    public string Field { get; set; } = string.Empty; // Örn: "DisplayName"
    public string Operator { get; set; } = "eq";       // eq, contains, gt, lt vs.
    public string Value { get; set; } = string.Empty;  // Örn: "Debi"
}
