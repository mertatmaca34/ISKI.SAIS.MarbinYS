using Microsoft.Extensions.Logging;
using System.Net;
using System.Text.Json;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Hosting;
using Microsoft.Data.SqlClient;

namespace ISKI.Core.CrossCuttingConcerns.Exceptions.ExceptionHandling;

public class ExceptionMiddleware(RequestDelegate next, ILogger<ExceptionMiddleware> logger, IHostEnvironment env)
{
    private readonly RequestDelegate _next = next;
    private readonly ILogger<ExceptionMiddleware> _logger = logger;
    private readonly IHostEnvironment _env = env;

    public async Task InvokeAsync(HttpContext context)
    {
        try
        {
            await _next(context);
        }
        catch (BusinessException bx)
        {
            _logger.LogWarning(bx, "İş kuralı ihlali");
            context.Response.StatusCode = 400;
            await WriteErrorResponse(context, bx.Message);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, ex.Message);
            context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;

            string message = _env.IsDevelopment() ? ex.Message : "Beklenmeyen bir hata oluştu.";
            string? detail = _env.IsDevelopment() ? ex.StackTrace?.ToString() : null;

            // Özel kontrol: SqlException içeriyor mu?
            if (ex.GetType().Namespace == "Microsoft.Data.SqlClient")
                message = "Veritabanı bağlantısı kurulamadı. Lütfen sistem yöneticisine başvurun.";

            await WriteErrorResponse(context, message, detail);
        }
    }

    private static async Task WriteErrorResponse(HttpContext context, string message, string? detail = null)
    {
        context.Response.ContentType = "application/json";
        var response = new ErrorResponse(context.Response.StatusCode, message, detail);

        var options = new JsonSerializerOptions { PropertyNamingPolicy = JsonNamingPolicy.CamelCase };
        var json = JsonSerializer.Serialize(response, options);

        await context.Response.WriteAsync(json);
    }
}