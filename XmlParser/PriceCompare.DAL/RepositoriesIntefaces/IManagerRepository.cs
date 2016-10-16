using System.Collections.Generic;
using System.Threading.Tasks;
using PriceCompare.Model;

namespace PriceCompare.DAL.RepositoriesIntefaces
{
    //Well done- encapsulating the DAO is a very good practice.
    //However- issues may arise since the returned types are annotated with EF attributes
    //Consider: http://automapper.org/ and https://github.com/AutoMapper/AutoMapper/wiki/Getting-started
    public interface IManagerRepository
    {
        Task<IEnumerable<Item>> GetItemsWithManufactureNameAsync(string manufactureName);
        Task<IEnumerable<Item>> GetItemsByNameAsync(string itemName);
        Task AddItemToCartAsync(long itemCode, int cartId);
    }
}
