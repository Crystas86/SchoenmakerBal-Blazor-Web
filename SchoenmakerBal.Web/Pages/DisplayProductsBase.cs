using Microsoft.AspNetCore.Components;
using SchoenmakerBal.Models.Dtos;

namespace SchoenmakerBal.Web.Pages
{
    public class DisplayProductsBase : ComponentBase
    {
        [Parameter]
        public IEnumerable<ProductDto> Products { get; set; }
    }
}
