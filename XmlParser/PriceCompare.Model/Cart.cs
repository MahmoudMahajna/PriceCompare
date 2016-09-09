using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PriceCompare.Model
{
    public class Cart
    {
        public Cart()
        {
            ItemsInCart=new HashSet<ItemCart>();
        }

        [Key]
        public int CartId { get; set; }
       
        public virtual ICollection<ItemCart> ItemsInCart { get; set; }
    }
}