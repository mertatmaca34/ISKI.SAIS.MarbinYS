using System.Text.Json.Serialization;

namespace Infrastructure.Remote.SAIS.DTOs.Requests;

public sealed class LoginRequest
{
    [JsonPropertyName("username")]
    public string Username { get; init; } = string.Empty;

    [JsonPropertyName("password")]
    public string PasswordHash { get; init; } = string.Empty;
}
