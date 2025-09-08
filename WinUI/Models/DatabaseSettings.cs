using System.Text.Json.Serialization;

namespace WinUI.Models;

public class DatabaseSettings
{
    public string Server { get; set; } = string.Empty;
    public string Authentication { get; set; } = "Windows Authentication";
    public string? Username { get; set; }
    public string? Password { get; set; }
    public string LogLevel { get; set; } = "Information";
}
