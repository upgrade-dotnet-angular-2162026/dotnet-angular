using ECart.DAL.Database;
using ECart.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ECart.DAL.Repositories
{
    public class ProductRepository:IProductRepository
    {
        private readonly ProductDBContext productDBContext;

        public ProductRepository(ProductDBContext productDBContext)
        {
            this.productDBContext = productDBContext;
        }

        public void Add(Product product)
        {
            productDBContext.Products.Add(product);
            productDBContext.SaveChanges();
        }

        public void Delete(int id)
        {
            var product = productDBContext.Products.Find(id);
            productDBContext.Products.Remove(product);
            productDBContext.SaveChanges();
        }

        public Product GetProduct(string name)
        {
            var product = productDBContext.Products.SingleOrDefault(p => p.Name == name);
            return product;
        }

        public List<Product> GetProducts()
        {
            var products=productDBContext.Products.ToList();
            return products;
        }

        public void Update(Product product)
        {
            productDBContext.Products.Update(product);
            productDBContext.SaveChanges();
        }
    }
}
