using SchoenmakerBal.Models.Dtos;

namespace SchoenmakerBal.Web.Services.Contracts
{
    public interface IManageProductsLocalStorageService
    {
        Task<IEnumerable<ProductDto>> GetCollection();
        Task RemoveCollection();
    }
}
