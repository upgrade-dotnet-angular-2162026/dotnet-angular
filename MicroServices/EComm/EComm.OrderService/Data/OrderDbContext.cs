using Microsoft.EntityFrameworkCore;
namespace EComm.OrderService.Data
{
    public class OrderDbContext:DbContext
    {
        public OrderDbContext(DbContextOptions<OrderDbContext> options):base(options)
        {
        }
        public DbSet<Entities.Order> Orders { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Entities.Order>().HasKey(o => o.OrderId);

        }
    }
}
