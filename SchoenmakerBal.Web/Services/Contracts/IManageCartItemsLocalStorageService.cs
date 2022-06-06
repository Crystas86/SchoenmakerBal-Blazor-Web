using SchoenmakerBal.Models.Dtos;

namespace SchoenmakerBal.Web.Services.Contracts
{
    public interface IManageCartItemsLocalStorageService
    {
        Task<List<CartItemDto>> GetCollections();
        Task SaveCollection(List<CartItemDto> cartItemsDto);
        Task RemoveCollection();
    }
}
