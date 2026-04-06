using HandsOnMVCUsingEFWithAsync.Entities;
using HandsOnMVCUsingEFWithAsync.Repositories;
using Microsoft.EntityFrameworkCore;

namespace HandsOnMVCUsingEFWithAsync
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();
            var connection = builder.Configuration.GetConnectionString("MovieConnectionString");
            builder.Services.AddDbContext<MovieDbContext>(options => options.UseSqlServer(connection));
            builder.Services.AddTransient<IMovieRepository, MovieRepository>();
            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
            }
            app.UseRouting();

            app.UseAuthorization();

            app.MapStaticAssets();
            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}")
                .WithStaticAssets();

            app.Run();
        }
    }
}
