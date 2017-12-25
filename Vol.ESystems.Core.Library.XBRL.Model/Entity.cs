using System.Xml.Serialization;

namespace Vol.ESystems.Core.Library.XBRL.Model
{
    [XmlRoot(ElementName = "entity", Namespace = "http://www.xbrl.org/2003/instance")]
    public class Entity
    {
        [XmlElement(ElementName = "identifier", Namespace = "http://www.xbrl.org/2003/instance")]
        public Identifier Identifier { get; set; }
    }
}