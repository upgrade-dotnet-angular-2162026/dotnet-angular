using HandsOnMVCUsingEFCore.Entities;
using Microsoft.EntityFrameworkCore;
namespace HandsOnMVCUsingEFCore.DataBase
{
    public class AppDBContext:DbContext
    {
        //defind dbset
        public DbSet<Book> Books { get; set;  }
        //define connectionstring
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-4O1D65I\\SQLEXPRESS;Initial Catalog=EFCoreDb;Integrated Security=True;Encrypt=True;Trust Server Certificate=True");
        }
    }
}
