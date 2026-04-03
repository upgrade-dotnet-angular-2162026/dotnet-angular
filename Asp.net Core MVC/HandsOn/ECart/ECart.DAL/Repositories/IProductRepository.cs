using ECart.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ECart.DAL.Repositories
{
    public interface IProductRepository
    {
        List<Product> GetProducts();
        Product GetProduct(string name);
        void Add(Product product);
        void Update(Product product);
        void Delete(int id);
    }
}
