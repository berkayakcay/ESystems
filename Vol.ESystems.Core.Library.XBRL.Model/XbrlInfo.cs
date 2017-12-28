using System.Xml.Serialization;

namespace Vol.ESystems.Core.Library.XBRL.Model
{
    [XmlRoot(ElementName = "xbrlInfo", Namespace = "http://www.xbrl.org/int/gl/cor/2006-10-25")]
    public class XbrlInfo
    {
        [XmlElement(ElementName = "xbrlInclude", Namespace = "http://www.xbrl.org/int/gl/cor/2006-10-25")]
        public XbrlInclude XbrlInclude { get; set; }
    }
}