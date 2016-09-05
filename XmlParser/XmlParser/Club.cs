using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace PriceCompare.XmlParser
{
    public class Club
    {
        [XmlElement("ClubId")]
        int ClubId { get; set; }
    }
}
