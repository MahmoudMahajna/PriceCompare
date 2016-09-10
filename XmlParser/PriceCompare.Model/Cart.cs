using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using PriceCompare.Model.Interfaces;

namespace PriceCompare.Model
{
    public class Cart:ICart
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