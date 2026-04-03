using ECart.BAL.DTOs;
using ECart.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ECart.BAL.Services
{
    public interface IProductService
    {
        List<ProductDto> GetProducts();
        ProductDto GetProduct(string name);
        void Add(ProductDto product);
        void Update(ProductDto product);
        void Delete(int id);
    }
}
