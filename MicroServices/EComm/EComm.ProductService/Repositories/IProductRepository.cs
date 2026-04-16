using EComm.ProductService.Entities;
namespace EComm.ProductService.Repositories
{
    public interface IProductRepository
    {
        Task CreateProductAsync(Product product);
        Task UpdateProductAsync(int id, Product product);
        Task DeleteProductAsync(int id);
        Task<Product> GetProductByIdAsync(int productId);
        Task<List<Product>> GetAllProductsAsync();
    }
}
