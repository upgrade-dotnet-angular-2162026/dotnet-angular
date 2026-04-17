using System;
using System.Collections.Generic;
using System.Text;

namespace MathLibrary
{
    public class ProductRepository
    {
        public Product Details(int id)
        {
            return new Product()
            {
                Id = id,
                Name = "Laptop",
                Price = 56000
            };
        }
        public List<Product> GetProducts()
        {
            return new List<Product>()
            {
                new Product(){Id=1,Name="Mouse",Price=500},
                 new Product(){Id=2,Name="Keyboard",Price=500},
            };
        }
    }
}
