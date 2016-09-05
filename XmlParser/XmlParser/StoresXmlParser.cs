using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace PriceCompare.XmlParser
{
    public class StoresXmlParser : FileXmlParser
    {
        
        public override object Parse(StreamReader xmlFile)
        {
            var serializer = new XmlSerializer(typeof(StoresCollection));
            var stores = (StoresCollection)serializer.Deserialize(xmlFile);
            stores.SetStoreDetailsForItems();
            return stores;
        }
    }
}
