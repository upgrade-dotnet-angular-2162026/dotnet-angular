using Dapper;
using HandsOnDapper_Demo.Models;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace HandsOnDapper_Demo
{
    internal class Demo2
    {
        string connectionString = "Data Source=DESKTOP-4O1D65I\\SQLEXPRESS;Initial Catalog=ADMDOTNET;Integrated Security=True;Encrypt=True;Trust Server Certificate=True";
        IDbConnection db;
        public Demo2()
        {
            db = new SqlConnection(connectionString);
        }
        private void BulkInsert()
        {
            var sql = "INSERT INTO Product (Id,Name, Price,Stock) VALUES (@Id,@Name, @Price,@Stock)";

            var products = new List<Product>
{
    new Product { Id=5,Name = "A", Price = 100,Stock=100 },
    new Product { Id=9,Name = "B", Price = 200,Stock=200 }
};

            db.Execute(sql, products);
        }
        private void BulkUpdate()
        {
            var sql = "UPDATE Product SET Price = @Price WHERE Id = @Id";
            var products = new List<Product>
{
    new Product { Id = 1, Price = 100 },
    new Product { Id = 2, Price = 200 }
};
            db.Execute(sql, products);
        }
        private void BulkDelete()
        {
            var sql = "DELETE FROM Product WHERE Id = @Id";
            var products = new List<int>
{
   1,3,4,5
};
            db.Execute(sql, products.Select(id => new { Id = id }));
        }
    }
    static void Main()
        {
            Demo2 obj = new Demo2();
            obj.BulkInsert();
            obj.BulkUpdate();
            obj.BulkDelete();
        }
    }
