using System.Xml.Serialization;

namespace Vol.ESystems.Core.Library.XBRL.Model
{
    [XmlRoot(ElementName = "period", Namespace = "http://www.xbrl.org/2003/instance")]
    public class Period
    {
        [XmlElement(ElementName = "instant", Namespace = "http://www.xbrl.org/2003/instance")]
        public string Instant { get; set; }
    }
}