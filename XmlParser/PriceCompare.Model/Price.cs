using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace PriceCompare.Model
{
    public class Price
    {
        [Key]
        [Column(Order = 1)]
        public long ItemCode {get;set;}
        [Key]
        [Column(Order = 2)]
        public int StoreId { get; set; }
        public float ItemPrice { get; set; }
        public double Quantity { get; set; }
        public double UnitOfMeasurePrice { get; set; }

        public virtual Item Item { get; set; }
        public virtual Store Store { get; set; }
    }
}