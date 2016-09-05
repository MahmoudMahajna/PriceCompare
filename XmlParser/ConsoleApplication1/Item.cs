using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ConsoleApplication1
{
    public class Item
    {
        public int ItemId { get; set; }
        public string ItemCode { get; set; }
        public int ItemType { get; set; }

        //public virtual ICollection<Price> Prices { get; set; }
    }
}