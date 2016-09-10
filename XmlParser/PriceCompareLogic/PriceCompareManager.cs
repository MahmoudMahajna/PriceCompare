using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PriceCompare.DAL.Data;
using PriceCompare.DAL.Repositories;
using PriceCompare.Model;

namespace PriceCompareLogic
{
    public class PriceCompareManager: IPriceCompareManager
    {
        public User User { get; }

        public PriceCompareManager(User user)
        {
            User = user;
        }

        public async Task<IEnumerable<Item>> GetItemsWithManufactureNameAsync(string manufactureName)
        {
            if (manufactureName == null)
            {
                throw new ArgumentNullException(nameof(manufactureName));
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
                var managerReop = new ManagerRepository(context);
                return await managerReop.GetItemsByNameAsync(itemName);
            }
        }

        public async Task AddItemToCartAsync(long itemCode)
        {
            using (var context = new PriceCompareDbContext())
            {
                var managerRep = new ManagerRepository(context);
                await managerRep.AddItemToCartAsync(itemCode, User.CartId);
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

        public async Task UpdateItemInCartAsync(long itemCode, int itemCount)
        {
            using (var context = new PriceCompareDbContext())
            {
                var cartRep = new CartRepository(context);
                await cartRep.UpdateItemCountAsync(itemCode, itemCount);
            }
        }

        public async Task RemoveItemFromCartAsync(long itemCode)
        {
            using (var context = new PriceCompareDbContext())
            {
                var cartRep = new CartRepository(context);
                await cartRep.RemoveItemFromCartAsync(itemCode);
            }
        }

        public IEnumerable<Chain> GetChains()
        {
            using (var context = new PriceCompareDbContext())
            {
                var chainRep = new ChainRepository(context);
                return chainRep.GetChains();
            }
        }

        public IEnumerable<Store> GetStoresByChainId(string chainId)
        {
            if (chainId == null)
            {
                throw new ArgumentNullException(nameof(chainId));
            }
            using (var context = new PriceCompareDbContext())
            {
                var chainRep = new ChainRepository(context);
                return chainRep.GetStoresByChainId(chainId);
            }
        }

        public async Task<IEnumerable<Tuple<ItemCart, Price>>> GetItemsInCartPricesByStoreAsync(long chainId,int storeId, IEnumerable<ItemCart> items)
        {
            using (var context = new PriceCompareDbContext())
            {
                var priceRep = new PriceRepository(context);
                var allPricesInStore = await priceRep.GetPricesByStoreIdAsync(storeId, chainId);
                var pricesInStore = allPricesInStore.ToArray();
                if (pricesInStore.Count() != 0)
                {
                    return await Task.Run(() => items.ToList()
                                                .Select(item => new Tuple<ItemCart, Price>(item, pricesInStore
                                                                                            .FirstOrDefault( price => price.ItemCode == item.ItemCode))));
                }
                return null;
            }
        }

        public IEnumerable<ItemCart> GetNotFoundItemsInStore(IEnumerable<Tuple<ItemCart, Price>> itemPriceTuples)
        {
            return itemPriceTuples?.Where(itemPriceTuple => itemPriceTuple.Item2 == null)
                .Select(itemPriceTuple => itemPriceTuple.Item1);
        }

        public async Task<IEnumerable<Price>> GetItemsInStoreByStoreWithNameIdAsync(int storeId, string text,long chainId)
        {
            using (var context = new PriceCompareDbContext())
            {
                var priceRep=new PriceRepository(context);
                return await priceRep.GetItemsInStoreByStoreWithNameIdAsync(storeId, text,chainId);
            }
        }

        public async Task<Price> GetItemPriceByCodeAsync(long itemCode)
        {
            using (var context = new PriceCompareDbContext())
            {
                var priceRep=new PriceRepository(context);
                return await priceRep.GetItemPriceByCodeAsync(itemCode);
            }
        }

        public float CalculateTotalPrice(List<Tuple<float, int>> priceCountTuples)
        {
            float totalPrice = 0;
            priceCountTuples.ForEach(priceCount=>totalPrice+=priceCount.Item1*priceCount.Item2);
            return totalPrice;
        }

        public async Task<IEnumerable<Price>> GetItemsPricesInStoreSortedAscAsync(int storeId, long chainId)
        {
            using (var context=new PriceCompareDbContext())
            {
                var priceRep=new PriceRepository(context);
                return await priceRep.GetItemsPricesInStoreSortedAscAsync(storeId, chainId);
            }
        }
    }
}
