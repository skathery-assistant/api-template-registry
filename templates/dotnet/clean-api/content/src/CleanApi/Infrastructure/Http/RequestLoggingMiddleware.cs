using System.Diagnostics;

namespace CleanApi.Infrastructure.Http;

public sealed class RequestLoggingMiddleware(RequestDelegate next, ILogger<RequestLoggingMiddleware> logger)
{
    public async Task InvokeAsync(HttpContext context)
    {
        var stopwatch = Stopwatch.StartNew();

        using var scope = logger.BeginScope(new Dictionary<string, object?>
        {
            ["TraceId"] = context.TraceIdentifier,
            ["Path"] = context.Request.Path.Value
        });

        try
        {
            await next(context);
        }
        finally
        {
            logger.LogInformation(
                "HTTP {Method} {Path} => {StatusCode} in {ElapsedMs} ms",
                context.Request.Method,
                context.Request.Path,
                context.Response.StatusCode,
                stopwatch.ElapsedMilliseconds);
        }
    }
}
