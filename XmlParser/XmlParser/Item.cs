using System;
using System.Xml.Serialization;

namespace XmlParser
{
    [Serializable]
    public class Item : IItem
    {
        public long ChainId { get; set; }
        public int SubChainId { get; set; }
        public int StoreId { get; set; }
        public int BikoretNo { get; set; }
        [XmlElement("PriceUpdateDate")]
        public string PriceUpdateDate { get; set; }
        [XmlElement("ItemCode")]
        public long ItemCode { get; set; }
        [XmlElement("ItemType")]
        public int ItemType { get; set; }
        [XmlElement("ItemName")]
        public string ItemName { get; set; }
        [XmlElement("ManufacturerName")]
        public string ManufacturerName { get; set; }
        [XmlElement("Quantity")]
        public double Quantity { get; set; }
        [XmlElement("bIsWeighted")]
        public bool IsWeighted { get; set; }
        [XmlElement("ItemPrice")]
        public float ItemPrice { get; set; }
        [XmlElement("UnitOfMeasurePrice")]
        public double UnitOfMeasurePrice { get; set; }
    }
}
