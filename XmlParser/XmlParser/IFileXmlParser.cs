using System.Collections.Generic;
using System.IO;

namespace PriceCompare.XmlParser
{
    public interface IFileXmlParser
    {
       object Parse(StreamReader xmlFile);
    }
}