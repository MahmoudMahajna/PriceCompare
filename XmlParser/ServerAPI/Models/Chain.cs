using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ServerAPI.Models
{
    public class Chain
    {
        public string ChainId { get; set; }
        public string ChainName { get; set; }

        public virtual ICollection<Store> Stores { get; set; }
    }
}