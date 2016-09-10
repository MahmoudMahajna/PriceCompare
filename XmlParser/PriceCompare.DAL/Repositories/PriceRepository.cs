using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using PriceCompare.DAL.Data;
using PriceCompare.DAL.RepositoriesIntefaces;
using PriceCompare.Model;

namespace PriceCompare.DAL.Repositories
{
    public class PriceRepository:Repository,IPriceRepository
    {
       public PriceRepository(PriceCompareDbContext context):base(context)
        {
        }

        public async Task<IEnumerable<Price>> GetPricesByStoreIdAsync(int storeId)
        {
            return await _context.Prices.Where(price => price.StoreId==storeId).ToListAsync();
        }

        public async Task<IEnumerable<Price>> GetItemsInStoreByStoreWithNameIdAsync(int storeId, string text)
        {
            var pricesInStore =await  GetPricesByStoreIdAsync(storeId);
           return await Task.Run(()=> pricesInStore.Where(price=> price.ItemName.Contains(text)).ToList());
       }

        public async Task<Price> GetItemPriceByCodeAsync(long itemCode)
        {
           return await _context.Prices.FirstOrDefaultAsync(price => price.ItemCode == itemCode);
        }
    }
}