using System.Collections.Generic;
using System.Threading.Tasks;
using PriceCompare.Model;

namespace PriceCompare.DAL.RepositoriesIntefaces
{
    public  interface IItemRepository
    {
        Task<Item> GetItemByCodeAsync(long code);
        Task<IEnumerable<Item>> GetAllItemsAsync();
    }
}
