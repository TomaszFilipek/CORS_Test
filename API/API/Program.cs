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
                        builder.WithOrigins("http://localhost:4200",
                            "https://testcors.bieda.it",
                            "https://testcors.bieda.it/",
                             "https://testcorsng.bieda.it",
                            "https://testcorsng.bieda.it/",
                             "https://testcorsngg.bieda.it",
                            "https://testcorsngg.bieda.it/")
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
