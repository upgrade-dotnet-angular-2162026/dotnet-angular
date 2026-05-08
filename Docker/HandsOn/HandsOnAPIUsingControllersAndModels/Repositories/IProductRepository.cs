using HandsOnAPIUsingControllersAndModels.Models;

namespace HandsOnAPIUsingControllersAndModels.Repositories
{
    public interface IProductRepository
    {
        List<Product> GetAll();
        Product? Get(int id);
        void Update(Product product);
        void Delete(int id);
        void Add(Product product);
    }
}
