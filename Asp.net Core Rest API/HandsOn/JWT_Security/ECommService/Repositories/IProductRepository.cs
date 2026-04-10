using ECommService.Entities;

namespace ECommService.Repositories
{
    public interface IProductRepository
    {
        Task Add(Product product);
        Task Update(Product product);
        Task Delete(Product product);
        Task<Product> Search(string name);
        Task<Product> Get(int id);
        Task<List<Product>> GetAll();

    }
}
