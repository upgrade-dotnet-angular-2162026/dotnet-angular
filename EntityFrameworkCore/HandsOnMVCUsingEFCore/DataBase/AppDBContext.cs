using HandsOnMVCUsingEFCore.Entities;
using Microsoft.EntityFrameworkCore;
namespace HandsOnMVCUsingEFCore.DataBase
{
    public class AppDBContext:DbContext
    {
        //private IConfiguration configuration;
        //public AppDBContext(IConfiguration configuration)
        //{
        //    this.configuration = configuration;
        //}
        //define the below constructor when connectionstring defined in program.cs file
        public AppDBContext(DbContextOptions<AppDBContext> options):base(options) { }
        
        //defind dbset
        public DbSet<Book> Books { get; set;  }
        //define connectionstring
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    //optionsBuilder.UseSqlServer("Data Source=DESKTOP-4O1D65I\\SQLEXPRESS;Initial Catalog=EFCoreDb;Integrated Security=True;Encrypt=True;Trust Server Certificate=True");
        //    optionsBuilder.UseSqlServer(configuration.GetConnectionString("DefaultConnection"));
        //}
    }
}
