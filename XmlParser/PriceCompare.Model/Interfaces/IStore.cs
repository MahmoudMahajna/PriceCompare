using System.Collections.Generic;

namespace PriceCompare.Model.Interfaces
{
    public interface IStore
    {
        int StoreId { get; set; }
        string StoreName { get; set; }
        string ChainId { get; set; }
        int BikoretNo { get; set; }
        int StoreType { get; set; }
        Chain Chain { get; set; }
        ICollection<Price> Prices { get; set; }
    }
}