using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace PriceCompare.Model
{
    public class Store
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int StoreId { get; set; }
        public string StoreName { get; set; }
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