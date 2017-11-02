namespace CatsServer
{
    using Microsoft.AspNetCore.Builder;
    using Microsoft.Extensions.DependencyInjection;
    using Data;
    using Microsoft.EntityFrameworkCore;
    using Infrastructure.Extensions;


    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<CatsDbContext>(options =>
                options.UseSqlServer(AppSettings.DatabaseConnectionString));
        }

        public void Configure(IApplicationBuilder app)
        =>   app.UseDatabaseMigration()
                .UseStaticFiles()
                .UseHtmlContentType()
                .UseRequestHandlers()
                .UseRequestNotFound();
        
    }
}
