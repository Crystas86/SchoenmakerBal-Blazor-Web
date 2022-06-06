using Microsoft.EntityFrameworkCore;
using SchoenmakerBal.Api.Data;
using SchoenmakerBal.Api.Entities;
using SchoenmakerBal.Api.Repositories.Contracts;

namespace SchoenmakerBal.Api.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly SchoenmakerBalDbContext _schoenmakerBalDbContext;

        public ProductRepository(SchoenmakerBalDbContext schoenmakerBalDbContext)
        {
            _schoenmakerBalDbContext = schoenmakerBalDbContext;
        }

        public async Task<IEnumerable<ProductCategory>> GetCategories()
        {
            var categories = await _schoenmakerBalDbContext.ProductCategories.ToListAsync();

            return categories;
        }

        public async Task<ProductCategory> GetCategory(int id)
        {
            var category = await _schoenmakerBalDbContext.ProductCategories.SingleOrDefaultAsync(c => c.Id == id);
            return category;
        }

        public async Task<Product> GetItem(int id)
        {
            var product = await _schoenmakerBalDbContext.Products
                .Include(p => p.ProductCategory)
                .SingleOrDefaultAsync(p => p.Id == id);

            return product;
        }

        public async Task<IEnumerable<Product>> GetItems()
        {
            var products = await _schoenmakerBalDbContext.Products
                .Include(p => p.ProductCategory).ToArrayAsync();

            return products;
        }

        public async Task<IEnumerable<Product>> GetItemsByCategory(int id)
        {
            var products = await _schoenmakerBalDbContext.Products
                .Include(p => p.ProductCategory)
                .Where(p => p.CategoryId == id).ToListAsync();

            return products;
        }
    }
}
