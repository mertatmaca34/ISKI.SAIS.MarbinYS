namespace WinUI.Models;

public record DatabaseInfo(string Server, string? DatabaseName, long? StorageUsedMb, long? StorageAllocatedMb);
