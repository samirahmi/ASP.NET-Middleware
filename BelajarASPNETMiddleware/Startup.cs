using BelajarASPNETMiddleware.CustomMw;
using System.Text.Json.Serialization;

namespace BelajarASPNETMiddleware
{
    public class Startup
    {
        private readonly IConfiguration _configuration;

        public Startup(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public void ConfigureServices(IServiceCollection service)
        {
            service.AddControllers().AddJsonOptions(options =>
            options.JsonSerializerOptions.DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull
            );
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseMiddleware<CustomMiddleware>();
            app.UseHttpsRedirection();
            app.UseRouting();

            app.Use(async(context, next) =>
            {
                Console.WriteLine("Middleware here");
                await next();
                Console.WriteLine(context.Response.StatusCode);
            });

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
