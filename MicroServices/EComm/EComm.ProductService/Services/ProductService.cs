using EComm.ProductService.Repositories;
using EComm.ProductService.Entities;
using EComm.ProductService.DTOs;
using System.Linq;
using AutoMapper;
namespace EComm.ProductService.Services
{
    public class ProductService:IProductService
    {
        private readonly IProductRepository _productRepository;
        private readonly IMapper _mapper;
        public ProductService(IProductRepository productRepository, IMapper mapper = null)
        {
            _productRepository = productRepository;
            _mapper = mapper;
        }
        public async Task CreateProduct(CreateProductDto productDto)
        {
            //var product = new Product()
            //{
            //    Name=productDto.Name,
            //    Price=productDto.Price,
            //};
            //convert CreateProductDto to Product using AutoMapper
            var product = _mapper.Map<Product>(productDto);
           
            await _productRepository.CreateProductAsync(product);
        }
        public async Task DeleteProduct(int id)
        {
            await _productRepository.DeleteProductAsync(id);
        }
        public async Task<List<ReadProductDto>> GetAllProducts()
        {
            var products =await _productRepository.GetAllProductsAsync();
            //convert List<Product> to List<ReadProductDto> using AutoMapper
            var productDtos = _mapper.Map<List<ReadProductDto>>(products);
            //return products.Select(p => new ReadProductDto()
            //{
            //    Id = p.Id,
            //    Name = p.Name,
            //    Price = p.Price
            //}).ToList();
            return productDtos;
        }
        public async Task<ReadProductDto> GetProductById(int productId)
        {
            
            var product= await _productRepository.GetProductByIdAsync(productId);

            return _mapper.Map<ReadProductDto>(product);
           
        }
        public async Task UpdateProduct(int id, CreateProductDto productDto)
        {
            //var product = new Product()
            //{
            //    Id = id,
            //    Name = productDto.Name,
            //    Price= productDto.Price
            //};
            var product = _mapper.Map<Product>(productDto);
            product.Id = id;  
            await _productRepository.UpdateProductAsync(id, product);
        }

      
    }
}
