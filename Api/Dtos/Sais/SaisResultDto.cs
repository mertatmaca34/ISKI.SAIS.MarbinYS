using System.Text.Json.Serialization;

namespace Api.Dtos.Sais;

public class SaisResultDto
{
    [JsonPropertyName("result")]
    public bool Result { get; set; }

    [JsonPropertyName("message")]
    public string? Message { get; set; }

    [JsonPropertyName("objects")]
    public object? Objects { get; set; }

    public static SaisResultDto Success(string? message = null)
        => new() { Result = true, Message = message, Objects = null };

    public static SaisResultDto Failure(string? message = null)
        => new() { Result = false, Message = message, Objects = null };
}

public class SaisResultDto<T>
{
    [JsonPropertyName("result")]
    public bool Result { get; set; }

    [JsonPropertyName("message")]
    public string? Message { get; set; }

    [JsonPropertyName("objects")]
    public T? Objects { get; set; }

    public static SaisResultDto<T> Success(T? data, string? message = null)
        => new() { Result = true, Message = message, Objects = data };

    public static SaisResultDto<T> Failure(string? message = null)
        => new() { Result = false, Message = message, Objects = default };
}
