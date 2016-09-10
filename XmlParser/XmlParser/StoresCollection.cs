using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using PriceCompare.XmlParser;

namespace PriceCompare.XmlParser
{
    [Serializable]
    [XmlRoot("Root")]
   public class StoresCollection
    {
        [XmlArray("Stores")]
        [XmlArrayItem("Store", typeof(Store))]
        public Store[] Stores { get; set; }
        [XmlElement("ChainId")]
        public long ChainId { get; set; }
        [XmlElement("LastUpdateDate")]
        public string LastUpdateDate { get; set; }

        public void SetStoreDetailsForItems()
        {
            foreach (var store in Stores)
            {
                store.ChainId = ChainId;
            }
        }
    }
}
