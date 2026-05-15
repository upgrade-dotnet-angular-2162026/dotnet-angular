
using HandsOnAPIUsingControllersAndModels.Repositories;

namespace HandsOnAPIUsingControllersAndModels
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddSingleton<IProductRepository, ProductRepository>();
            // Add services to the container.

            builder.Services.AddControllers();
            //swagger services
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            // Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
            builder.Services.AddOpenApi();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.MapOpenApi();
                //swagger middleware
                app.UseSwagger();
                app.UseSwaggerUI();
            }
            else if(app.Environment.IsProduction())
            {
                //use swagger in production environment
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
