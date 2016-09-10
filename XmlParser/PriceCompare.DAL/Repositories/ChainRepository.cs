using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PriceCompare.DAL.Data;
using PriceCompare.Model;

namespace PriceCompare.DAL.Repositories
{
   public class ChainRepository
    {
       private readonly PriceCompareDbContext _context;

       public ChainRepository(PriceCompareDbContext context)
       {
           _context = context;
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
