using System.Xml.Serialization;

namespace Vol.ESystems.Core.Library.XBRL.Model
{
    [XmlRoot(ElementName = "segment", Namespace = "http://www.xbrl.org/2003/instance")]
    public class Segment
    {
        [XmlElement(ElementName = "numberOfEntries", Namespace = "http://www.xbrl.org/int/gl/bus/2006-10-25")]
        public NumberOfEntries NumberOfEntries { get; set; }
        [XmlElement(ElementName = "uniqueID", Namespace = "http://www.xbrl.org/int/gl/cor/2006-10-25")]
        public UniqueID UniqueID { get; set; }
    }
}