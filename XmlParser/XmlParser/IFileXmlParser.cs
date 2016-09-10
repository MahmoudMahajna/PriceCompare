using System.IO;

namespace XmlParser
{
    public interface IFileXmlParser
    {
       object Parse(StreamReader xmlFile);
    }
}