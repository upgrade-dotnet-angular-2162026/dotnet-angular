using HandsOnAPIUsingControllersAndModels.Models;
using System.Xml.Linq;

namespace HandsOnAPIUsingControllersAndModels.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private List<Product> products = new List<Product>()
            {
                new Product()
        {
                    Id = 33,
                    Name = "Bottle",
                    Price = 100
                }
            };
        public ProductRepository()
        {

        }
        public void Add(Product product)
        {
            products.Add(product);
        }

        public void Delete(int id)
        {
            var product = products.SingleOrDefault(p => p.Id == id);
            products.Remove(product);
        }

        public Product? Get(int id)
        {
            var product = products.SingleOrDefault(p => p.Id == id);
            return product;
        }

        public List<Product> GetAll()
        {
            return products;
        }

        public void Update(Product product)
        {
            for (int i = 0; i < products.Count; i++)
            {
                if (products[i].Id == product.Id)
                {
                    products[i].Price = product.Price;
                    break;
                }
            }
        }
    }
}
