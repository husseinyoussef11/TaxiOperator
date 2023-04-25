using Microsoft.AspNetCore.Builder;
using TaxiOperator.Middleware;

namespace TaxiOperator.Extension
{
    public static class LoggingMiddlewareExtension
    {
        public static IApplicationBuilder UseLoggingMiddleware(this IApplicationBuilder app)
        {
            return app.UseMiddleware<LoggingMiddleware>();
        }
    }
}