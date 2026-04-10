using ECommService.Database;
using ECommService.Entities;
using Microsoft.EntityFrameworkCore;

namespace ECommService.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly ECommDbContext _context;

        public ProductRepository(ECommDbContext context)
        {
            _context = context;
        }

        public async Task Add(Product product)
        {
           _context.Products.Add(product);
            await _context.SaveChangesAsync();
        }

        public async Task Delete(Product product)
        {
            _context.Products.Remove(product);
            await _context.SaveChangesAsync();
        }

        public async Task<Product> Get(int id)
        {
            var product = await _context.Products.FindAsync(id);
            return product;
        }

        public async Task<List<Product>> GetAll()
        {
            return await _context.Products.ToListAsync();
        }

        public async Task<Product> Search(string name)
        {
            var product=await _context.Products.SingleOrDefaultAsync(x => x.Name == name);
            return product;
        }

        public async Task Update(Product product)
        {
          _context.Products.Update(product);
            await _context.SaveChangesAsync();
        }
    }
}
