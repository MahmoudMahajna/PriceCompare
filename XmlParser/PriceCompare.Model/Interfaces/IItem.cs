using System.Collections.Generic;

namespace PriceCompare.Model.Interfaces
{
    public interface IItem
    {
        long ItemCode { get; set; }
        int ItemType { get; set; }
        string ItemName { get; set; }
        bool IsWeighted { get; set; }
        string ManufactureName { get; set; }
        ICollection<Price> Prices { get; set; }
        ICollection<ItemCart> CartsItem { get; set; }
    }
}