using Microsoft.AspNetCore.Http;

namespace CatsServer.Infrastructure.Extensions
{
    using System;
    using System.Linq;
    using System.Reflection;
    using Handlers.Contracts;
    using Middleware;
    using Microsoft.AspNetCore.Builder;

    public static class ApplicationBuilderExtension
    {
        public static IApplicationBuilder UseDatabaseMigration(this IApplicationBuilder builder)
        => builder.UseMiddleware<DatabaseMigrationMIddleware>();

        public static IApplicationBuilder UseHtmlContentType(this IApplicationBuilder builder)
            => builder.UseMiddleware<HtmlContentTypeMiddleware>();

        public static IApplicationBuilder UseRequestHandlers(this IApplicationBuilder builder)
        {
            var handlers = Assembly
                .GetEntryAssembly()
                .GetTypes()
                .Where(t => t.IsClass && typeof(IHandler).IsAssignableFrom(t))
                .Select(Activator.CreateInstance)
                .Cast<IHandler>()
                .OrderBy(h => h.Order)
                .ToList();

            foreach (var handler in handlers)
            {
                builder.MapWhen(handler.Condition, app =>
                {
                    app.Run(handler.RequestHandler);
                });
            }

            return builder;
        }

        public static void UseRequestNotFound(this IApplicationBuilder builder)
        {
            builder.Run(async (context) =>
            {
                context.Response.StatusCode = 404;
                await context.Response.WriteAsync("404 Page Was Not Found.");
            });
        }
    }
}
