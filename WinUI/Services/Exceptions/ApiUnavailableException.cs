using System;

namespace WinUI.Services.Exceptions;

public sealed class ApiUnavailableException : Exception
{
    public ApiUnavailableException()
    {
    }

    public ApiUnavailableException(string message)
        : base(message)
    {
    }

    public ApiUnavailableException(string message, Exception innerException)
        : base(message, innerException)
    {
    }
}
