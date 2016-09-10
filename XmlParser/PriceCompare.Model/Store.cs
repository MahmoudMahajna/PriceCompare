using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using PriceCompare.Model.Interfaces;

namespace PriceCompare.Model
{
    public class Store:IStore
    {
        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int StoreId { get; set; }
        public string StoreName { get; set; }
        [Key]
        [Column(Order = 2)]
        public string ChainId { get; set; }
        public int BikoretNo { get; set; }
        public int StoreType { get; set; }

        public Chain Chain { get; set; }
        public virtual ICollection<Price> Prices { get; set; }

        public override string ToString()
        {
            return StoreName;
        }

        public override bool Equals(object obj)
        {
            var store = obj as Store;
            return StoreId == store?.StoreId;
        }
    }
}