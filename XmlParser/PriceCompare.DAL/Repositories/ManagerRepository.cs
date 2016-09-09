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
    public class ManagerRepository
    {
        private readonly PriceCompareDbContext _context;

        public ManagerRepository(PriceCompareDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Item>> GetItemsWithManufactureNameAsync(string manufactureName)
        {
            if (manufactureName == null)
            {
                throw new ArgumentNullException(nameof(manufactureName));
            }
            return await _context.Items.Where(item => item.ManufactureName.Contains(manufactureName)).ToListAsync();
        }

        public async  Task<IEnumerable<Item>> GetItemsByNameAsync(string itemName)
        {
            if (itemName == null)
            {
                throw new ArgumentNullException(nameof(itemName));
            }
            return await _context.Items.Where(item => item.ItemName.Contains(itemName)).ToListAsync();
        }

        public async Task AddItemToCartAsync(long itemCode,int cartId)
        {
            var itemRep = new ItemRepository(_context);
            var item=await itemRep.GetItemByCodeAsync(itemCode);
            _context.ItemsCarts.AddOrUpdate(new ItemCart { CartId = cartId, ItemCode = itemCode,Count = 0,ItemName =item.ItemName });
            await _context.SaveChangesAsync();
        }
    }
}
