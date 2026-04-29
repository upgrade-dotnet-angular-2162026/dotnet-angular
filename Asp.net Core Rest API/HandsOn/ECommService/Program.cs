
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
            //configure cors
            builder.Services.AddCors(options =>
            {
                options.AddPolicy("AllowAll", policy =>
                {
                    policy.AllowAnyOrigin() //it allows any origin to access the API, you can specify the allowed origins instead of using AllowAnyOrigin()
                          .AllowAnyMethod() //it allows any HTTP method (GET, POST, PUT, DELETE, etc.) to be used when accessing the API
                          .AllowAnyHeader(); //it allows any header to be sent in the request
                });
            });
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
            app.UseCors("AllowAll");
            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
