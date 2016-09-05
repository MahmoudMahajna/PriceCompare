using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PriceCompare.XmlParser
{
    public class PromotionItem
    {
        public long ItemCode { get; set; }
        public int ItemType { get; set; }
        public int IsGiftItemType { get; set; }
    }
}
