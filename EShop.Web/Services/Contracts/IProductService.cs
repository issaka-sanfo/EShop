using EShop.Models.Dtos;

namespace EShop.Web.Services.Contracts
{
    public interface IProductService
    {
        Task<IEnumerable<ProductDto>> GetItems(); 
    }
}
