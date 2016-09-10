using System.Collections.Generic;
using PriceCompare.Model;

namespace PriceCompare.DAL.RepositoriesIntefaces
{
   public interface IChainRepository
   {
       IEnumerable<Chain> GetChains();
       IEnumerable<Store> GetStoresByChainId(string chainId);
   }
}
