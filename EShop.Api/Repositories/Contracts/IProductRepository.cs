using EShop.api.Entities;

namespace EShop.Api.Repositories.Contracts
{
    public interface IProductRepository
    {
        Task<IEnumerable<Product>> GetItems();
        Task<IEnumerable<ProductCategory>> GetCategories();
        Task<IEnumerable<Product>> GetItem();
        Task<IEnumerable<ProductCategory>> GetCategory();
    }
}
