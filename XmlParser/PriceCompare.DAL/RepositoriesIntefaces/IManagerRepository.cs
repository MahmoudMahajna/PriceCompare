using System.Collections.Generic;
using System.Threading.Tasks;
using PriceCompare.Model;

namespace PriceCompare.DAL.RepositoriesIntefaces
{
    public interface IManagerRepository
    {
        Task<IEnumerable<Item>> GetItemsWithManufactureNameAsync(string manufactureName);
        Task<IEnumerable<Item>> GetItemsByNameAsync(string itemName);
        Task AddItemToCartAsync(long itemCode, int cartId);
    }
}
