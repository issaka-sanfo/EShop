using EShop.Models.Dtos;
using EShop.Web.Services.Contracts;
using System.Net.Http.Json;

namespace EShop.Web.Services
{
    public class ProductService : IProductService
    {
        private readonly HttpClient httpClient;

        public ProductService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        public Task<IEnumerable<ProductDto>> GetItems()
        {
            try
            {
                var products = this.httpClient.GetFromJsonAsync<IEnumerable<ProductDto>>("api/Product");
                return products;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
