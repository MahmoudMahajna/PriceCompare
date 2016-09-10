using System.Collections.Generic;
using System.Linq;
using PriceCompare.DAL.Data;
using PriceCompare.DAL.RepositoriesIntefaces;
using PriceCompare.Model;

namespace PriceCompare.DAL.Repositories
{
   public class ChainRepository:Repository,IChainRepository
    {
       public ChainRepository(PriceCompareDbContext context):base(context)
       {
       }


       public IEnumerable<Chain> GetChains()
       {
          return _context.Chains.ToList();
       }

       public IEnumerable<Store> GetStoresByChainId(string chainId)
       {
           return _context.Stores.Where(store => store.ChainId.Equals(chainId)).ToList();
       }
    }
}
