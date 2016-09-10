using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using PriceCompare.Model.Interfaces;

namespace PriceCompare.Model
{
    public class Item:IItem
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

        public override bool Equals(object obj)
        {
            return ((Item)obj).ItemCode==ItemCode;
        }
    }
}