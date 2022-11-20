using EShop.Models.Dtos;
using Microsoft.AspNetCore.Components;

namespace EShop.Web.Pages
{
    public class DisplayProductsBase : ComponentBase
    {
        [Parameter]
        public IEnumerable<ProductDto> Products { get; set; }
    }
}
