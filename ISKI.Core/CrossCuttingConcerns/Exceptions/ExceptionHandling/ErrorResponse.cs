using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISKI.Core.CrossCuttingConcerns.Exceptions.ExceptionHandling;

public class ErrorResponse
{
    public int StatusCode { get; }
    public string Message { get; }
    public string? Details { get; }

    public ErrorResponse(int statusCode, string message, string? details = null)
    {
        StatusCode = statusCode;
        Message = message;
        Details = details;
    }
}
