using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PriceCompare.DAL.Data;
using PriceCompare.Model;

namespace PriceCompare.DAL.Repositories
{
    public  class ItemRepository
    {
        private readonly PriceCompareDbContext _context;

       public  ItemRepository(PriceCompareDbContext context)
        {
            _context = context;
        }

        public async Task<Item> GetItemByCode(long code)
        {
           return await _context.Items.FindAsync(code);
        }

        public async Task<IEnumerable<Item>> GetAllItems()
        {
            return await _context.Items.ToListAsync();
        }
    }
}
