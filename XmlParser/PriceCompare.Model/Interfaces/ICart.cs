using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PriceCompare.Model.Interfaces
{
    public interface ICart
    {

       int CartId { get; set; }
       ICollection<ItemCart> ItemsInCart { get; set; }
    }
}