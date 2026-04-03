using System;
using System.Collections.Generic;
using System.Text;
using ECart.DAL.Entities;
using Microsoft.EntityFrameworkCore;
namespace ECart.DAL.Database
{
    public class ProductDBContext:DbContext
    {
        public ProductDBContext(DbContextOptions<ProductDBContext> options):base(options) { }
        
        public DbSet<Product> Products { get; set; }

    }
}
