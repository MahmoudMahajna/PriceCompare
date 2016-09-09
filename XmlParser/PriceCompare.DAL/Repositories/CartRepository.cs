using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PriceCompare.DAL.Data;
using PriceCompare.Model;

namespace PriceCompare.DAL.Repositories
{
   public class CartRepository
    {
        private readonly PriceCompareDbContext _context;

       public CartRepository(PriceCompareDbContext context)
       {
           _context = context;
       }

        public async Task<IEnumerable<ItemCart>> GetCartItemsAsync(int cartId)
        {
            return await Task.Run(()=> _context.Carts.FirstOrDefault(cart => cart.CartId == cartId)?.ItemsInCart);
        }

       public async Task<Cart> GetCartById(int cartId)
       {
           return await _context.Carts.FirstOrDefaultAsync(cart => cart.CartId == cartId);
       }

       public async Task UpdateItemCountAsync(long itemCode,int count)
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
