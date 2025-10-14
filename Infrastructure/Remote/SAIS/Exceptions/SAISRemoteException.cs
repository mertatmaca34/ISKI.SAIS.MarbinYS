namespace Infrastructure.Remote.SAIS.Exceptions;

public sealed class SAISRemoteException : Exception
{
    public int StatusCode { get; }
    public string? RemoteMessage { get; }
    public IReadOnlyList<string>? RemoteErrors { get; }

    public SAISRemoteException(int statusCode, string? message, IReadOnlyList<string>? errors = null, Exception? inner = null)
        : base($"SAIS {statusCode}: {message}", inner)
    {
        StatusCode = statusCode;
        RemoteMessage = message;
        RemoteErrors = errors;
    }
}