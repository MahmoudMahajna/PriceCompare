using System.Collections.Generic;

namespace PriceCompare.Model.Interfaces
{
    public interface IChain
    {
        string ChainId { get; set; }
        string ChainName { get; set; }

        ICollection<Store> Stores { get; set; }

    }
}