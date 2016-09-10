using System.Collections.Generic;
using System.Threading.Tasks;
using PriceCompare.Model;

namespace PriceCompare.DAL.RepositoriesIntefaces
{
    public interface ICartRepository
    {
        Task<IEnumerable<ItemCart>> GetCartItemsAsync(int cartId);
        Task<Cart> GetCartById(int cartId);
        Task UpdateItemCountAsync(long itemCode, int count);
        Task RemoveItemFromCartAsync(long itemCode);
    }
}
