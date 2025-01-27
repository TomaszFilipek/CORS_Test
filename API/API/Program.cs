using Microsoft.Extensions.Options;

namespace API
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddCors(options =>
            {
                options.AddPolicy("AllowAllOrigins",
                    builder =>
                    {
                        builder.WithOrigins(
                              "http://xxtestapp.toadres.pl",
                              "https://xxtestapp.toadres.pl",
                              "http://xxtestapp.toadres.pl/",
                              "https://xxtestapp.toadres.pl/")
                            .AllowAnyHeader()
                            .AllowAnyMethod()
                            .AllowCredentials();
                    });

            });

            // builder.WebHost.UseKestrel();

            // Add services to the container.

            builder.Services.AddControllers();

            var app = builder.Build();

            app.UseCors("AllowAllOrigins");
            // Configure the HTTP request pipeline.

          //  app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
