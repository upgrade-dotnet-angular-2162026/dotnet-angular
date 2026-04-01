using HandsOnEFCoreCodeFirstDemo_1.Entities;
using HandsOnEFCoreCodeFirstDemo_1.Repositories;

namespace HandsOnEFCoreCodeFirstDemo_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                ProductRepository productRepository =
                        new ProductRepository();
                //Product product = new Product()
                //{
                //    Name = "Speakrs",
                //    Price = 1800
                //};
                //productRepository.AddProduct(product);
                //fetch all product
                var products = productRepository.GetProducts();
                foreach (var item in products)
                {
                    Console.WriteLine($"Id:{item.Id} " +
                        $"Name:{item.Name} Price:{item.Price}");
                }
                //fetch single record
                var product = productRepository.GetProduct(2);
                Console.WriteLine($"Id:{product.Id} " +
                       $"Name:{product.Name} Price:{product.Price}");
                //fetch record by name
                product = productRepository.GetProductByName("Mouse");
                if (product != null)
                {
                    Console.WriteLine($"Id:{product.Id} " +
                          $"Name:{product.Name} Price:{product.Price}");
                }
                else
                {
                    Console.WriteLine("Invalid Product Name");
                }
                //edit product details
                product = productRepository.GetProduct(2);
                product.Price = 900;
                productRepository.EditProduct(product);
                Console.WriteLine();
                //delete record
                product= productRepository.GetProduct(3);
                productRepository.DeleteProduct(product);
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
        }
    }
}
