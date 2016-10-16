using System.Collections.Generic;
using PriceCompare.Model;

namespace PriceCompare.DAL.RepositoriesIntefaces
{
    //Well done- encapsulating the DAO is a very good practice.
    //However- issues may arise since the returned types are annotated with EF attributes
    //Consider: http://automapper.org/ and https://github.com/AutoMapper/AutoMapper/wiki/Getting-started
    public interface IChainRepository
   {
       IEnumerable<Chain> GetChains();
       IEnumerable<Store> GetStoresByChainId(string chainId);
   }
}
