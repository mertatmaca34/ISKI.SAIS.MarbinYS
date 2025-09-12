using Microsoft.AspNetCore.Builder;

namespace ISKI.Core.CrossCuttingConcerns.Exceptions.ExceptionHandling;

public static class ExceptionMiddlewareExtensions
{
    public static IApplicationBuilder UseGlobalExceptionHandling(this IApplicationBuilder app)
    {
        return app.UseMiddleware<ExceptionMiddleware>();
    }
}
