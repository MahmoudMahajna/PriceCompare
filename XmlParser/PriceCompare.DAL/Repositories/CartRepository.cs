using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using PriceCompare.DAL.Data;
using PriceCompare.DAL.RepositoriesIntefaces;
using PriceCompare.Model;

namespace PriceCompare.DAL.Repositories
{
    public class CartRepository:Repository,ICartRepository
    { 
        public CartRepository(PriceCompareDbContext context):base(context)
        {
        }

        public async Task<IEnumerable<ItemCart>> GetCartItemsAsync(int cartId)
        {
            return await Task.Run(() => _context.Carts.FirstOrDefault(cart => cart.CartId == cartId)?.ItemsInCart);
        }

        public async Task<Cart> GetCartById(int cartId)
        {
            return await _context.Carts.FirstOrDefaultAsync(cart => cart.CartId == cartId);
        }

        public async Task UpdateItemCountAsync(long itemCode, int count)
        {
            var itemInCart = await _context.ItemsCarts.FirstOrDefaultAsync(item => item.ItemCode == itemCode);
            itemInCart.Count = count;
            await _context.SaveChangesAsync();
        }

        public async Task RemoveItemFromCartAsync(long itemCode)
        {
            var itemInCart = await _context.ItemsCarts.FirstOrDefaultAsync(item => item.ItemCode == itemCode);
            _context.ItemsCarts.Remove(itemInCart);
            await _context.SaveChangesAsync();
        }
    }
}
