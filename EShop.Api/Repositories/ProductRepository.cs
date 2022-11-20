using EShop.api.Data;
using EShop.api.Entities;
using EShop.Api.Repositories.Contracts;
using Microsoft.EntityFrameworkCore;

namespace EShop.Api.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly EShopDbContext eShopDbContext;

        public ProductRepository(EShopDbContext eShopDbContext)
        {
            this.eShopDbContext = eShopDbContext;
        }
        public async Task<IEnumerable<ProductCategory>> GetCategories()
        {
            var categories = await this.eShopDbContext.ProductCategories.ToListAsync();
            return categories;
        }

        public Task<IEnumerable<ProductCategory>> GetCategory()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Product>> GetItem()
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Product>> GetItems()
        {
            var products = await this.eShopDbContext.Products.ToListAsync();
            return products;
        }
    }
}
