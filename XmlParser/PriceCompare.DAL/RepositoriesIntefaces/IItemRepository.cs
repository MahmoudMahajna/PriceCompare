using System.Collections.Generic;
using System.Threading.Tasks;
using PriceCompare.Model;

namespace PriceCompare.DAL.RepositoriesIntefaces
{
    //Well done- encapsulating the DAO is a very good practice.
    //However- issues may arise since the returned types are annotated with EF attributes
    //Consider: http://automapper.org/ and https://github.com/AutoMapper/AutoMapper/wiki/Getting-started
    public interface IItemRepository
    {
        Task<Item> GetItemByCodeAsync(long code);
        Task<IEnumerable<Item>> GetAllItemsAsync();
    }
}
