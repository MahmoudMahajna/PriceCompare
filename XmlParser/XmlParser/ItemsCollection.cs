using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace PriceCompare.XmlParser
{
    [Serializable]
    [XmlRoot("root")]
    public class ItemsCollection
    {
        [XmlArray("Items")]
        [XmlArrayItem("Item", typeof(Item))]
        public Item[] Items { get; set; }
        [XmlElement("ChainId")]
        public long ChainId { get; set; }
        [XmlElement("SubChainId")]
        public int SubChainId { get; set; }
        [XmlElement("StoreId")]
        public int StoreId { get; set; }
        [XmlElement("BikoretNo")]
        public int BikoretNo { get; set; }

        public void SetStoreDetailsForItems()
        {
            foreach (var item in Items)
            {
                item.ChainId = ChainId;
                item.SubChainId = SubChainId;
                item.StoreId = StoreId;
                item.BikoretNo = BikoretNo;
            }
        }
    }
}
