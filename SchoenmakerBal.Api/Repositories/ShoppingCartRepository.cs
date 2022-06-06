using Microsoft.EntityFrameworkCore;
using SchoenmakerBal.Api.Data;
using SchoenmakerBal.Api.Entities;
using SchoenmakerBal.Api.Repositories.Contracts;
using SchoenmakerBal.Models.Dtos;

namespace SchoenmakerBal.Api.Repositories
{
    public class ShoppingCartRepository : IShoppingCartRepository
    {
        private readonly SchoenmakerBalDbContext _schoenmakerBalDbContext;

        public ShoppingCartRepository(SchoenmakerBalDbContext schoenmakerBalDbContext)
        {
            _schoenmakerBalDbContext = schoenmakerBalDbContext;
        }
        private async Task<bool> CartItemExists(int cartId, int productId)
        {
            return await _schoenmakerBalDbContext.CartItems.AnyAsync(c => c.CartId == cartId &&
                                                                          c.ProductId == productId);
        }

        public async Task<CartItem> AddItem(CartItemToAddDto cartItemToAddDto)
        {
            if (await CartItemExists(cartItemToAddDto.CartId, cartItemToAddDto.ProductId) == false)
            {
                var item = await (from product in _schoenmakerBalDbContext.Products
                                  where product.Id == cartItemToAddDto.ProductId
                                  select new CartItem
                                  {
                                      CartId = cartItemToAddDto.CartId,
                                      ProductId = product.Id,
                                      Qty = cartItemToAddDto.Qty
                                  }).SingleOrDefaultAsync();

                if (item != null)
                {
                    var result = await _schoenmakerBalDbContext.CartItems.AddAsync(item);
                    await _schoenmakerBalDbContext.SaveChangesAsync();
                    return result.Entity;
                }
            }

            return null;
        }

        public async Task<CartItem> DeleteItem(int id)
        {
            var item = await _schoenmakerBalDbContext.CartItems.FindAsync(id);

            if (item != null)
            {
                _schoenmakerBalDbContext.CartItems.Remove(item);
                await _schoenmakerBalDbContext.SaveChangesAsync();
            }

            return item;
        }

        public async Task<CartItem> GetItem(int id)
        {
            return await (from cart in _schoenmakerBalDbContext.Carts
                          join cartItem in _schoenmakerBalDbContext.CartItems
                          on cart.Id equals cartItem.CartId
                          where cartItem.Id == id
                          select new CartItem
                          {
                              Id = cartItem.Id,
                              ProductId = cartItem.ProductId,
                              Qty = cartItem.Qty,
                              CartId = cartItem.CartId
                          }).SingleOrDefaultAsync();
        }

        public async Task<IEnumerable<CartItem>> GetItems(int userId)
        {
            return await (from cart in _schoenmakerBalDbContext.Carts
                          join cartItem in _schoenmakerBalDbContext.CartItems
                          on cart.Id equals cartItem.CartId
                          where cart.UserId == userId
                          select new CartItem
                          {
                              Id = cartItem.Id,
                              ProductId = cartItem.ProductId,
                              Qty = cartItem.Qty,
                              CartId = cartItem.CartId
                          }).ToListAsync();
        }

        public async Task<CartItem> UpdateQty(int id, CartItemQtyUpdateDto cartItemQtyUpdateDto)
        {
            var item = await _schoenmakerBalDbContext.CartItems.FindAsync(id);

            if (item != null)
            {
                item.Qty = cartItemQtyUpdateDto.Qty;
                await _schoenmakerBalDbContext.SaveChangesAsync();
                return item;
            }

            return null;
        }
    }
}
