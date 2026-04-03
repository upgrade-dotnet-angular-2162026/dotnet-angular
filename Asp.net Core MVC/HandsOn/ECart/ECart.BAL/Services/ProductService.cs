using ECart.BAL.DTOs;
using ECart.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using ECart.DAL.Repositories;
namespace ECart.BAL.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _repository;
        public ProductService(IProductRepository repository)
        {
            _repository = repository;
        }
        public void Add(ProductDto productDto)
        {
            //converting ProductDto to Product

            var product = new Product()
            {
                Name = productDto.Name,
                Price = productDto.Price
            };
            _repository.Add(product);
        }

        public void Delete(int id)
        {
           _repository.Delete(id);
        }

        public ProductDto GetProduct(string name)
        {
            var product = _repository.GetProduct(name);
            //convert entity to Dto
            return new ProductDto()
            {
                Id=product.Id,
                Name=product.Name,
                Price=product.Price
            };
        }

        public List<ProductDto> GetProducts()
        {
            var products = _repository.GetProducts();
            //convert List<Product> to List<ProductDto>
            return products.Select(p => new ProductDto()
            {
                Id = p.Id,
                Name = p.Name,
                Price = p.Price
            }).ToList();
           
        }

        public void Update(ProductDto productDto)
        {
            //converting ProductDto to Product
            var product = new Product()
            {
                Id=productDto.Id,
                Name = productDto.Name,
                Price = productDto.Price
            };
            _repository.Update(product);
        }
    }
}
