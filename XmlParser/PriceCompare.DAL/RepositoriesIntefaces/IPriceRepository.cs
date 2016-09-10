using System.Collections.Generic;
using System.Threading.Tasks;
using PriceCompare.Model;

namespace PriceCompare.DAL.RepositoriesIntefaces
{
    public interface IPriceRepository
    {
        Task<IEnumerable<Price>> GetPricesByStoreIdAsync(int storeId);
        Task<IEnumerable<Price>> GetItemsInStoreByStoreWithNameIdAsync(int storeId, string name);
        Task<Price> GetItemPriceByCodeAsync(long itemCode);
    }
}