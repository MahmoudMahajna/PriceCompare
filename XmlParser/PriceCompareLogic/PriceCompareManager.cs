using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using PriceCompare.DAL.Data;
using PriceCompare.DAL.Repositories;
using PriceCompare.Model;

namespace PriceCompare.Logic
{
    public class PriceCompareManager
    {
        public User User { get; private set; }

        public PriceCompareManager(User user)
        {
            User = user;
        }

        public async Task<IEnumerable<Item>> GetItemsWithManufactureNameAsync(string manufactureName)
        {
            if (manufactureName == null)
            {
                throw  new ArgumentNullException(nameof(manufactureName));
            }
            using (var context = new PriceCompareDbContext())
            {
                var managerRep = new ManagerRepository(context);
                return await managerRep.GetItemsWithManufactureNameAsync(manufactureName);
            }
        }

        public async Task<IEnumerable<Item>> GetItemsByNameAsync(string itemName)
        {
            if (itemName == null)
            {
                throw new ArgumentNullException();
            }
            using (var context = new PriceCompareDbContext())
            {
                var managerReop=new ManagerRepository(context);
                return await managerReop.GetItemsByNameAsync(itemName);
            }
        }

        public async Task AddItemToCartAsync(long itemCode)
        {
            using (var context = new PriceCompareDbContext())
            {
                var managerRep=new ManagerRepository(context);
                await managerRep.AddItemToCartAsync(itemCode,User.CartId);
            }
        }

        public async Task<IEnumerable<ItemCart>> GetCartItemsAsync()
        {
            using (var context = new PriceCompareDbContext())
            {
                var cartRep = new CartRepository(context);
                return await cartRep.GetCartItemsAsync(User.CartId);
            }
        }

        public async Task UpdateItemInCartAsync(long itemCode,int itemCount)
        {
            using (var context = new PriceCompareDbContext())
            {
                var cartRep=new CartRepository(context);
                await cartRep.UpdateItemCountAsync(itemCode,itemCount);
            }
        }

        public async Task RemoveItemFromCartAsync(long itemCode)
        {
            using (var context = new PriceCompareDbContext())
            {
                var cartRep=new CartRepository(context);
                await cartRep.RemoveItemFromCartAsync(itemCode);
            }
            
        }
    }
}
