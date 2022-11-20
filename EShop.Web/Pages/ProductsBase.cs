using EShop.Models.Dtos;
using EShop.Web.Services;
using EShop.Web.Services.Contracts;
using Microsoft.AspNetCore.Components;

namespace EShop.Web.Pages
{
    public class ProductsBase : ComponentBase
    {
        [Inject]
        public IProductService ProductService { get; set; }

        public IEnumerable<ProductDto> Products { get; set; }

        protected override async Task OnInitializedAsync()
        {
            Products = await ProductService.GetItems();
        }
    }
}
