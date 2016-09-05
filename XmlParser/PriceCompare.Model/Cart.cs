using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PriceCompare.Model
{
    public class Cart
    {
        [Key]
        public int CartId { get; set; }
       
        public virtual ICollection<ItemInCart> ItemsInCart { get; set; }
    }
}