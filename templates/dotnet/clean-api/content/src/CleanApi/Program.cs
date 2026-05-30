using System.Text.Json;
using System.Text.Json.Serialization;
using CleanApi.Features.Widgets;
using CleanApi.Infrastructure.Http;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Http.Json;

var builder = WebApplication.CreateBuilder(args);

builder.Logging.ClearProviders();
builder.Logging.AddSimpleConsole(options =>
{
    options.IncludeScopes = true;
    options.SingleLine = true;
    options.TimestampFormat = "HH:mm:ss ";
});
builder.Logging.SetMinimumLevel(LogLevel.Information);

builder.Services.ConfigureHttpJsonOptions(options =>
{
    options.SerializerOptions.PropertyNamingPolicy = JsonNamingPolicy.CamelCase;
    options.SerializerOptions.DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull;
    options.SerializerOptions.WriteIndented = false;
});

builder.Services.AddProblemDetails(options =>
{
    options.CustomizeProblemDetails = context =>
    {
        context.ProblemDetails.Extensions["traceId"] = context.HttpContext.TraceIdentifier;
        context.ProblemDetails.Instance = context.HttpContext.Request.Path;
    };
});
builder.Services.AddHealthChecks();
builder.Services.AddSingleton<WidgetStore>();

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseMiddleware<SecurityHeadersMiddleware>();
app.UseExceptionHandler("/error");
app.UseMiddleware<RequestLoggingMiddleware>();

app.MapGet("/", () => Results.Ok(new
{
    service = "CleanApi",
    status = "running",
    environment = app.Environment.EnvironmentName
}))
.WithName("Root")
.WithTags("System");

app.MapGet("/health", () => Results.Ok(new HealthResponse(
    Status: "Healthy",
    Environment: app.Environment.EnvironmentName,
    UtcNow: DateTimeOffset.UtcNow)))
.WithName("Health")
.WithTags("System");

app.MapGet("/error", (HttpContext context) =>
{
    var exceptionFeature = context.Features.Get<IExceptionHandlerPathFeature>();
    var detail = app.Environment.IsDevelopment()
        ? exceptionFeature?.Error.Message
        : "The request could not be completed.";

    return Results.Problem(
        title: "An unexpected error occurred.",
        detail: detail,
        statusCode: StatusCodes.Status500InternalServerError,
        instance: context.Request.Path);
})
.ExcludeFromDescription();

app.MapGroup("/api/widgets")
    .WithTags("Widgets")
    .MapWidgetEndpoints();

app.MapHealthChecks("/live")
   .ExcludeFromDescription();

app.Run();

public sealed record HealthResponse(string Status, string Environment, DateTimeOffset UtcNow);
