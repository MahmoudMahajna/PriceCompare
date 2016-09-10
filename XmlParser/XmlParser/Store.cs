using System.Xml.Serialization;

namespace XmlParser
{
    public class Store:IStore
    {
        public long ChainId { get; set; }
        [XmlElement("SubChainId")]
        public string SubChainId { get; set; }
        [XmlElement("StoreId")]
        public int StoreId { get; set; }
        [XmlElement("BikoretNo")]
        public int BikoretNo { get; set; }
        [XmlElement("StoreType")]
        public int StoreType { get; set; }
        [XmlElement("ChainName")]
        public string ChainName { get; set; }
        [XmlElement("SubChainName")]
        public string SubChainName { get; set; }
        [XmlElement("StoreName")]
        public string StoreName { get; set; }
        [XmlElement("Address")]
        public string Address { get; set; }
        [XmlElement("City")]
        public string City { get; set; }
        [XmlElement("ZipCode")]
        public string ZipCode { get; set; }
    }
}
