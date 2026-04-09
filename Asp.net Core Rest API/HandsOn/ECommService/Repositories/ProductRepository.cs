using ECommService.Entities;

namespace ECommService.Repositories
{
    public class ProductRepository : IProductRepository
    {
        public Task Add(Product product)
        {
            throw new NotImplementedException();
        }

        public Task Delete(Product product)
        {
            throw new NotImplementedException();
        }

        public Task<Product> Get(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Product>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<Product> Search(string name)
        {
            throw new NotImplementedException();
        }

        public Task Update(Product product)
        {
            throw new NotImplementedException();
        }
    }
}
