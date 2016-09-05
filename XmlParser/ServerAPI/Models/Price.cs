using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ServerAPI.Models
{
    public class Price
    {
       public int ItemId{get;set;}
        public int StoreId { get; set; }
        public float ItemPrice { get; set; }

        public virtual Item Item { get; set; }
        public virtual Store Store { get; set; }
    }
}