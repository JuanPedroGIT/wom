using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace API
{

    public class Program
    {
        public static async Task Main(string[] args)
        {
            var host = CreateHostBuilder(args).Build(); //.Run()
                                                        //esto es para comprobar si exite la base de datos y crearla
            using (var scope = host.Services.CreateScope())
            {
                var services = scope.ServiceProvider;
                var loggerFactory = services.GetRequiredService<ILoggerFactory>();
                try
                {
                    var context = services.GetRequiredService<WomContext>();
                    await context.Database.MigrateAsync();
                    await WomContextSeed.SeedAsinc(context, loggerFactory);
                }
                catch(Exception e)
                {
                    var logger = loggerFactory.CreateLogger<Program>();
                    logger.LogError(e, "Un error ha ocurrido durante la migración");

                }
            }

            host.Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}

