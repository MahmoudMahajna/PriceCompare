using System.IO;

namespace XmlParser
{
  public abstract class FileXmlParser:IFileXmlParser
   {
       public abstract object Parse(StreamReader xmlFile);
   }
}
