﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PriceCompare.Model
{
    public class ItemInCart
    {
        [Key]
        [Column(Order = 1)]
        public long ItemCode { get; set; }
        [Key]
        [Column(Order = 2)]
        public int CartId { get; set; }

        public Item Item { get; set; }
        public Cart Cart { get; set; }
    }
}
