﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using PriceCompare.Model.Interfaces;

namespace PriceCompare.Model
{
    public class ItemCart:IItemCart
    {
        [Key]
        [Column(Order = 1)]
        public long ItemCode { get; set; }
        [Key]
        [Column(Order = 2)]
        public int CartId { get; set; }

        public string  ItemName { get; set; }
        public int Count { get; set; }
        public Item Item { get; set; }
        public Cart Cart { get; set; }

        public override string ToString()
        {
            return ItemName;
        }
    }
}