using System.Collections.Generic;
using System.Data.Entity;
using System.Threading.Tasks;
using PriceCompare.DAL.Data;
using PriceCompare.DAL.RepositoriesIntefaces;
using PriceCompare.Model;

namespace PriceCompare.DAL.Repositories
{
    public  class ItemRepository:Repository,IItemRepository
    {
       public  ItemRepository(PriceCompareDbContext context):base(context)
        {
        }

        public async Task<Item> GetItemByCodeAsync(long code)
        {
           return await _context.Items.FindAsync(code);
        }

        public async Task<IEnumerable<Item>> GetAllItemsAsync()
        {
            return await _context.Items.ToListAsync();
        }
    }
}
