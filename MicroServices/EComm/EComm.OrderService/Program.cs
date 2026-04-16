
using EComm.OrderService.Repositories;
using EComm.OrderService.Services;
using Microsoft.EntityFrameworkCore;

namespace EComm.OrderService
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddDbContext<Data.OrderDbContext>(options =>
                options.UseSqlServer(builder.Configuration.GetConnectionString("OrderDbConnection")));
            builder.Services.AddTransient<IOrderRepository, OrderRepository>();
            builder.Services.AddScoped<IOrderService,OrderService.Services.OrderService>();
            builder.Services.AddControllers();
            //configure AutoMapper
            builder.Services.AddAutoMapper(cts=> { },AppDomain.CurrentDomain.GetAssemblies());
             builder.Services.AddTransient<Repositories.IOrderRepository, Repositories.OrderRepository>();
             builder.Services.AddTransient<Services.IOrderService, Services.OrderService>();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
