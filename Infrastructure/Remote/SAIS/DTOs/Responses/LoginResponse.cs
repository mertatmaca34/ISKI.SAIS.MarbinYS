using System.Text.Json.Serialization;

namespace Infrastructure.Remote.SAIS.DTOs.Responses;

public sealed class LoginResponse
{
    [JsonPropertyName("TicketId")]
    public string TicketId { get; init; } = string.Empty;

    [JsonPropertyName("DeviceId")]
    public string? DeviceId { get; init; }

    [JsonPropertyName("User")]
    public SaisUserResponse? User { get; init; }
}

public sealed class SaisUserResponse
{
    [JsonPropertyName("loginname")]
    public string? LoginName { get; init; }

    [JsonExtensionData]
    public Dictionary<string, object?> AdditionalData { get; init; } = new();
}
