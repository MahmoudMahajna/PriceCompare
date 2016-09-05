using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PriceCompare.Model
{
    public class Chain
    {
        public string ChainId { get; set; }
        public string ChainName { get; set; }

        public virtual ICollection<Store> Stores { get; set; }
    }
}