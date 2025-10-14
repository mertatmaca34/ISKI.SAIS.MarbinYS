namespace Infrastructure.Remote.SAIS.Models;

public sealed class SaisApiException : Exception
{
    public SaisApiException(string message)
        : base(message)
    {
    }

    public SaisApiException(string message, Exception innerException)
        : base(message, innerException)
    {
    }
}
