using PriceCompare.XmlParser;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace PriceCompare.XmlParser
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
