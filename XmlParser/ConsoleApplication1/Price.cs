using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ConsoleApplication1
{
    public class Price
    {
        public int PriceId { get; set; }
       public int ItemId {get;set;}
        public int StoreId { get; set; }
        public float ItemPrice { get; set; }

        public virtual Item Item { get; set; }
        public virtual Store Store { get; set; }
    }
}