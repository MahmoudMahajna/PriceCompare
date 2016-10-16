using System.IO;

namespace XmlParser
{
    public interface IFileXmlParser
    {
        //Why not 'T Parse<T>(StreamReader xmlFile);'?

        object Parse(StreamReader xmlFile);
    }
}