using EComm.ProductService.DTOs;
using EComm.ProductService.Entities;

namespace EComm.ProductService.Services
{
    public interface IProductService
    {
        Task  CreateProduct(CreateProductDto product);
        Task UpdateProduct(int id, CreateProductDto product);
        Task DeleteProduct(int id);
        Task<ReadProductDto> GetProductById(int productId);
        Task<List<ReadProductDto>> GetAllProducts();
    }
}
