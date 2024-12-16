using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using RestApiExample.Models;

namespace RestApiExample
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.ConfigureServices(services =>
                    {
                        // Add API driver services
                        services.AddControllers();
                    });
                    
                    webBuilder.Configure(app =>
                    {
                        // HTTP request pipeline configuration
                        app.UseHttpsRedirection();
                        app.UseRouting();

                        app.UseEndpoints(endpoints =>
                        {
                            endpoints.MapControllers(); // Mapea los controladores
                        });
                    });
                });
    }
}
