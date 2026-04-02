using HandsOnEFDBFirst.Enities;

namespace HandsOnEFDBFirst
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            BikeStoresContext context=new BikeStoresContext();
            var products = context.Products.ToList();
            foreach (var product in products)
            {
                Console.WriteLine($"Id:{product.ProductId} Name:{product.ProductName} Price:{product.ListPrice}");
            }
        }
    }
}
