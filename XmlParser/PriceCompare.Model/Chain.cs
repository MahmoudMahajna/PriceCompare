using System.Collections.Generic;
using PriceCompare.Model.Interfaces;

namespace PriceCompare.Model
{
    public class Chain:IChain
    {
        public string ChainId { get; set; }
        public string ChainName { get; set; }

        public virtual ICollection<Store> Stores { get; set; }

        public override string ToString()
        {
            return ChainName;
        }
    }
}