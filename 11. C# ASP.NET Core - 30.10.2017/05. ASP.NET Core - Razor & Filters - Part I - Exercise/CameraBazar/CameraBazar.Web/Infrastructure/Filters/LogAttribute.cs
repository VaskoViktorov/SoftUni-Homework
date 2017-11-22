using System;
using System.Threading.Tasks;

namespace CameraBazar.Web.Infrastructure.Filters
{
    using Microsoft.AspNetCore.Mvc.Filters;
    using System.IO;

    public class LogAttribute : ActionFilterAttribute
    {
        public override void OnResultExecuted(ResultExecutedContext context)
        {
            using (var writer = new StreamWriter("logs.txt",true))
            {
                var dateTime = DateTime.UtcNow;
                var ipAddress = context.HttpContext.Connection.RemoteIpAddress;
                var username = context.HttpContext.User?.Identity?.Name ?? "Annonymous";
                var controller = context.Controller.GetType().Name;
                var action = context.RouteData.Values["action"];

                var logMessage = $"{dateTime} - {ipAddress} - {username} - {controller}.{action}";

                if (context.Exception != null)
                {
                    var exceptionType = context.Exception.GetType().Name;
                    var exceptionMessage = context.Exception.Message;

                    logMessage = $"[!] {logMessage} - {exceptionType} - {exceptionMessage}";
                }

                writer.WriteLine(logMessage);
            }
        }
    }
}
