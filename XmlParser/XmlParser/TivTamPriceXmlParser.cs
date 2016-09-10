using System.IO;
using System.Xml.Serialization;

namespace XmlParser
{
   public class TivTamPriceXmlParser:FileXmlParser
    {
        public override object Parse(StreamReader xmlFile)
        {

                var serializer = new XmlSerializer(typeof(TivTamItemCollection));
                var items = (TivTamItemCollection)serializer.Deserialize(xmlFile);
                items.SetStoreDetailsForItems();
                return items;

        }
    }
}
