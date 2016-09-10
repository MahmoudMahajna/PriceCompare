using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using PriceCompare.Model.Interfaces;

namespace PriceCompare.Model
{
    public class Price:IPrice,IComparable<Price>
    {
        [Key]
        [Column(Order = 1)]
        public long ItemCode {get;set;}
        [Key]
        [Column(Order = 2)]
        public int StoreId { get; set; }
        [Key]
        [Column(Order = 3)]
        public long ChainId { get; set; }
        public string ItemName { get; set; }
        public float ItemPrice { get; set; }
        public double Quantity { get; set; }
        public double UnitOfMeasurePrice { get; set; }

        public virtual Item Item { get; set; }
        public virtual Store Store { get; set; }


        public int CompareTo(Price other)
        {
            var value = other.ItemPrice - ItemPrice;
            return value < 0 ? 1 : value > 0 ? -1 : 0;
        }

        public override string ToString()
        {
            return ItemName;
        }
    }
}