using System.Data;
using Microsoft.Data.SqlClient;
using Dapper;
using HandsOnDapper_Demo.Models;
namespace HandsOnDapper_Demo
{
    internal class Program
    {
        string connectionString = "Data Source=DESKTOP-4O1D65I\\SQLEXPRESS;" +
            "Initial Catalog=ADMDOTNET;Integrated Security=True;Encrypt=True;" +
            "Trust Server Certificate=True";
        IDbConnection db;
        public Program()
        {
            db = new SqlConnection(connectionString);
        }
        
        private void GetById(int id)
        {

            try
            {
                db.Open();// Open the connection
                          //Fetching a record from the Product table by Id
                var sql = "SELECT * FROM Product WHERE Id = @Id";
               // var product = db.QuerySingle<Product>($"SELECT * FROM Product where Id={id}");
                var product = db.QuerySingleOrDefault<Product>(sql, new { Id = id });
                if (product == null)
                {
                    Console.WriteLine($"No product found with Id: {id}");

                }
                else
                {
                    Console.WriteLine($"Id: {product.Id}, Name: {product.Name}, Price: {product.Price}, Stock: {product.Stock}");
                }
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                db.Close();
            }



        }

        private void GetAll()
        {

            try
            {
                db.Open();// Open the connection
                          //Fetching all records from the Product table
                var products = db.Query<Product>("SELECT * FROM Product").ToList();
                // Displaying the records
                foreach (var product in products)
                {
                    Console.WriteLine($"Id: {product.Id}, Name: {product.Name}, Price: {product.Price}, Stock: {product.Stock}");
                }
                Console.WriteLine();
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                db.Close(); // Ensure the connection is closed in case of an exception
            }

        }
        private void AddProduct(Product product)
        {
            try
            {
                db.Open();
                var sql = "INSERT INTO Product (Id,Name, Price, Stock) VALUES (@Id,@Name, @Price, @Stock)";
                db.Execute(sql, product);
                Console.WriteLine("Product added successfully.");
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                db.Close();
            }
        }
        private void DeleteProduct(int Id) {
            try
            {
                db.Open();
                var sql = "DELETE FROM Product WHERE Id = @Id";
                db.Execute(sql, new { Id = Id });
                Console.WriteLine("Product deleted successfully.");
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                db.Close();
            }
        }
        private void UpdateProduct(Product product)
        {
            try
            {
                db.Open();
                var sql = "UPDATE Product SET  Price = @Price, Stock = @Stock WHERE Id = @Id";
                db.Execute(sql, product);
                Console.WriteLine("Product updated successfully.");
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                db.Close();
            }
        }
        private void CountProducts()
        {
            try
            {
                db.Open();
                var count = db.ExecuteScalar<int>("SELECT COUNT(*) FROM Product");
                Console.WriteLine($"Total number of products: {count}");
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                db.Close();
            }
        }
       
        //Anonymous Parameters in Dapper
        private void GetProductByIdAndNameUsingAnonymousParameters(int id,string name)
        {
            try
            {
                var sql= "SELECT * FROM Product WHERE Id = @Id AND Name = @Name";
                db.Open();
                var product = db.QuerySingle<Product>(sql, new { Id = id,Name=name });
                if (product != null)
                {
                    Console.WriteLine($"Id: {product.Id}, Name: {product.Name}, Price: {product.Price}, Stock: {product.Stock}");
                }
                else
                {
                    Console.WriteLine($"No product found with Id: {id}");
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                db.Close();
            }
        }
        private void GetAllProductsUsingProcedure()
        {
            try
            {
                db.Open();
                var products = db.Query<Product>("GetAllProducts").ToList();
                foreach (var product in products)
                {
                    Console.WriteLine($"Id: {product.Id}, Name: {product.Name}, Price: {product.Price}, Stock: {product.Stock}");
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                db.Close();
            }
        }
        private void GetProductByIdUsingProcedure(int id)
        {
            try
            {
                db.Open();
                var product = db.QuerySingle<Product>("GetProductById", new { ProductId = id }, commandType: CommandType.StoredProcedure);
                if (product != null)
                {
                    Console.WriteLine($"Id: {product.Id}, Name: {product.Name}, Price: {product.Price}, Stock: {product.Stock}");
                }
                else
                {
                    Console.WriteLine($"No product found with Id: {id}");
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                db.Close();
            }
        }
        static void Main(string[] args)
        {
            try
            {
                Program program = new Program();
                program.GetAll();
                Console.WriteLine();
                //program.GetById(3);
                //program.AddProduct(new Product
                //{
                //    Id = 10,
                //    Name = "Product1",
                //    Price = 100,
                //    Stock = 50
                //});
                Console.WriteLine();
                program.GetAll();
                //program.DeleteProduct(10);
                Console.WriteLine("Enter the Id of the product you want to update:");
                int Id = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the new Price:");
                int price = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the new Stock:");
                int stock = int.Parse(Console.ReadLine());
                program.UpdateProduct(new Product
                {
                    Id = Id,
                    Price = price,
                    Stock = stock
                });
                //Console.WriteLine("Enter the Id of the product you want to fetch:");
                //if (int.TryParse(Console.ReadLine(), out int id))
                //{
                //    program.GetById(id);
                //}
                //else
                //{
                //    Console.WriteLine("Invalid Id entered.");
                //}
                //program.GetAll();
                // program.CountProducts();

                //program.GetAllProductsUsingProcedure();
                // program.GetProductByIdUsingProcedure(1);
                //   program.GetProductByIdAndNameUsingAnonymousParameters(1, "Sample Product");


                //    Console.WriteLine("Enter the Id of the product you want to delete:");
                //    if (int.TryParse(Console.ReadLine(), out int deleteId))
                //    {
                //        program.DeleteProduct(deleteId);
                //    }
                //    else
                //    {
                //        Console.WriteLine("Invalid Id entered.");
                //    }


            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }

        }
    }
}
