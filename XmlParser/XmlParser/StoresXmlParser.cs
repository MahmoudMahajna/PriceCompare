using System.IO;
using System.Xml.Serialization;

namespace XmlParser
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
