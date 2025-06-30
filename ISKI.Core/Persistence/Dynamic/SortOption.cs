namespace ISKI.Core.Persistence.Dynamic;

public class SortOption
{
    public string Field { get; set; } = string.Empty; // Örn: "DisplayName"
    public string Direction { get; set; } = "asc";    // asc / desc
}
