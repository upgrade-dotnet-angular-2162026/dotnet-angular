using ECommService.Entities;
using Microsoft.EntityFrameworkCore;
namespace ECommService.Database
{
    public class ECommDbContext:DbContext
    {
        public ECommDbContext(DbContextOptions<ECommDbContext> options):base(options) { }
       
        public DbSet<User> Users { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}
