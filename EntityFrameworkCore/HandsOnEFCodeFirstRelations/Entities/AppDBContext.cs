using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
namespace HandsOnEFCodeFirstRelations.Entities
{
    internal class AppDBContext:DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Order> Orders { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-4O1D65I\\SQLEXPRESS;Initial Catalog=TestDb42;Integrated Security=True;Encrypt=True;Trust Server Certificate=True");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Configure the Book Entity using FuluentAPI
            modelBuilder.Entity<Book>(entity =>
            {
                //set primary key
                entity.HasKey(b => b.BookId);
                entity.ToTable("Books"); //set table name
                //Title Configuration
                entity.Property(b => b.Title)
                .IsRequired() //Not null
                .HasColumnType("varchar")
                .HasMaxLength(50); //Nvarchar(50)
                //Author
                entity.Property(b=>b.Author)
                .IsRequired()
                .HasMaxLength(50);
                //Price
                entity.Property(b => b.Price)
                .HasColumnType("decimal(10,2)")
                .HasDefaultValue(0);
                //publish Date
                entity.Property(b => b.PublishDate)
                .HasColumnType("date")
                .HasDefaultValueSql("GetDate()");

                //seed data(add data while create the table
                entity.HasData(
                    new Book() { BookId=1,Title="Asp.net Core MVC",
                        Author="Microsoft",Price=1200,
                        PublishDate=new DateTime(2021,12,23)},
                       new Book() { BookId = 2, Title = "Angular 20.1", 
                           Author = "Google", Price = 2000, 
                           PublishDate = new DateTime(2025, 12, 23) }
                    );
            });
          
           

        }
    }
}
