using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using PriceCompare.Model;

namespace PriceCompareLogic
{
    public interface IPriceCompareManager
    {
        User User { get; }

        Task<IEnumerable<Item>> GetItemsWithManufactureNameAsync(string manufactureName);

        Task<IEnumerable<Item>> GetItemsByNameAsync(string itemName);

        Task AddItemToCartAsync(long itemCode);
        
        Task<IEnumerable<ItemCart>> GetCartItemsAsync();

        Task UpdateItemInCartAsync(long itemCode, int itemCount);

        Task RemoveItemFromCartAsync(long itemCode);

        IEnumerable<Chain> GetChains();

        IEnumerable<Store> GetStoresByChainId(string chainId);

        Task<IEnumerable<Tuple<ItemCart, Price>>> GetItemsInCartPricesByStoreAsync(long chainId,int storeId,
            IEnumerable<ItemCart> items);

        IEnumerable<ItemCart> GetNotFoundItemsInStore(IEnumerable<Tuple<ItemCart, Price>> itemPriceTuples);

        Task<IEnumerable<Price>> GetItemsInStoreByStoreWithNameIdAsync(int storeId, string text, long chainId);

        Task<Price> GetItemPriceByCodeAsync(long itemCode);

        float CalculateTotalPrice(List<Tuple<float, int>> priceCountTuples);
    }
}

