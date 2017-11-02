namespace CatsServer.Middleware
{
    using System.Threading.Tasks;
    using Data;
    using Microsoft.AspNetCore.Http;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.Extensions.DependencyInjection;

    public class DatabaseMigrationMIddleware
    {
        private readonly RequestDelegate next;

        public DatabaseMigrationMIddleware(RequestDelegate next)
        {
            this.next = next;
        }

        public Task Invoke(HttpContext context)
        {
            context.RequestServices.GetRequiredService<CatsDbContext>().Database.Migrate();
            return this.next(context);
        }
    }
}
