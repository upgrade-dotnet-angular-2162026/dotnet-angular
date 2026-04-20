using Microsoft.EntityFrameworkCore;
using EComm.IdentityService.Entities;
namespace EComm.IdentityService.Data
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            //seed data
            modelBuilder.Entity<User>().HasData(
                new User() { UserId="U0003",UserName="Karan",Password="12345",Role="Admin",Email="karan@gmail.com"}
                );
        }
    }
}
