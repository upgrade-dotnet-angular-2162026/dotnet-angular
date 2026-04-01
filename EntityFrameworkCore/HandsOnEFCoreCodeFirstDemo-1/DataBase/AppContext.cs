using System;
using System.Collections.Generic;
using System.Text;
using HandsOnEFCoreCodeFirstDemo_1.Entities;
using Microsoft.EntityFrameworkCore;
namespace HandsOnEFCoreCodeFirstDemo_1.DataBase
{
    //here AppContext is the DbContext class
    internal class AppContext:DbContext
    {
        //define the dbset
        public DbSet<Product> Products { get; set; }
       // public DbSet<Order> Orders { get; set; }
        //define the connectionstring
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //connect to sqlserver db
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-4O1D65I\\SQLEXPRESS;Initial Catalog=EFCoreDb;Integrated Security=True;Encrypt=True;Trust Server Certificate=True");
        }
    }
}
