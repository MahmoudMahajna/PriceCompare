using System;
using System.Xml.Serialization;

namespace XmlParser
{
    [Serializable]
    [XmlRoot("root")]
    public class ShofesalItemsCollection
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
