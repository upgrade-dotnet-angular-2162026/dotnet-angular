
using ECommService.Database;
using ECommService.Repositories;
using Microsoft.EntityFrameworkCore;

namespace ECommService
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            var connection = builder.Configuration.GetConnectionString("ECommConnection");
            builder.Services.AddDbContext<ECommDbContext>(options => options.UseSqlServer(connection));
            builder.Services.AddTransient<IUserRepository, UserRepository>();
            builder.Services.AddTransient<IProductRepository,ProductRepository>();
            builder.Services.AddControllers();
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            // Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
            builder.Services.AddOpenApi();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.MapOpenApi();
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
