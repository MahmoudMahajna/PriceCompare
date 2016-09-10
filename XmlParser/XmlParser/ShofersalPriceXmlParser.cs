using System.IO;
using System.Xml.Serialization;

namespace XmlParser
{
   public class ShofersalPriceXmlParser : FileXmlParser
    {
        public override object Parse(StreamReader xmlFile)
        {
            var serializer = new XmlSerializer(typeof(ShofesalItemsCollection));
            var items=(ShofesalItemsCollection) serializer.Deserialize(xmlFile);
            items.SetStoreDetailsForItems();
            return items;

        }
    }
}
