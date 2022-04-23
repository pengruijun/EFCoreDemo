using Microsoft.AspNetCore.Http.Extensions;

namespace EFCoreDemo.Middlewares;

public class PrintUrlMiddleware
{
    private readonly RequestDelegate _next;
    private readonly ILogger<PrintUrlMiddleware> _logger;

    public PrintUrlMiddleware(RequestDelegate next, ILogger<PrintUrlMiddleware> logger)
    {
        _next = next;
        _logger = logger;
    }

    public async Task InvokeAsync(HttpContext context)
    {
        // do something on context
        //await context.Response.WriteAsync($"Url: {context.Request.GetDisplayUrl()}");
        _logger.LogInformation("log from middle ware");
        await _next(context);
    }
}

public static class PrintUrlMiddelwareExtensions
{
    public static IApplicationBuilder UsePrintUrl(this IApplicationBuilder app)
    {
        return app.UseMiddleware<PrintUrlMiddleware>();
    }
}