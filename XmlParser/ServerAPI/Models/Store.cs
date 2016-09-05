using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ServerAPI.Models
{
    public class Store
    {
        public int StoreId { get; set; }
        public string ChainId { get; set; }
        public int BikoretNo { get; set; }
        public int StoreType { get; set; }

        public Chain Chain { get; set; }
        public virtual ICollection<Price> Prices { get; set; }
    }
}