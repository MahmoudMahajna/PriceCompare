using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Permissions;
using System.Web;

namespace PriceCompare.Model
{
    public class Item
    {
        public Item()
        {
            CartsItem=new HashSet<ItemCart>();
        }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long ItemCode { get; set; }
        public int ItemType { get; set; }
        public string ItemName { get; set; }
        public bool IsWeighted { get; set; }
        public string ManufactureName { get; set; }

        public virtual ICollection<Price> Prices { get; set; }
        public virtual ICollection<ItemCart> CartsItem { get; set; }

        public override string ToString()
        {
            return ItemName;
        }
    }
}