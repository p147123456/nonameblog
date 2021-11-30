using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Nonameblog.Models;
using System;
using Microsoft.EntityFrameworkCore;
using Nonameblog.Data;

namespace Nonameblog
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var host = CreateWebHostBuilder(args).Build();

            using (var scope = host.Services.CreateScope())
            {
                var services = scope.ServiceProvider;

                try
                {
                    var context = services.
                        GetRequiredService<NonameblogContext>();
                    context.Database.Migrate();
                    CreateData.NonameblogInit(services);

                    var context2 = services.
                        GetRequiredService<ApplicationDbContext>();
                    context2.Database.Migrate();
                    CreateData.MemberInit(services);

                }
                catch (Exception ex)
                {
                    var logger = services.GetRequiredService<ILogger<Program>>();
                    logger.LogError(ex, "An error occurred seeding the DB.");
                }
            }

            host.Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>();
    }
}