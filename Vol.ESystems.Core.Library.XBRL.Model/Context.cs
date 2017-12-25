using System.Xml.Serialization;

namespace Vol.ESystems.Core.Library.XBRL.Model
{
    [XmlRoot(ElementName = "context", Namespace = "http://www.xbrl.org/2003/instance")]
    public class Context
    {
        [XmlElement(ElementName = "entity", Namespace = "http://www.xbrl.org/2003/instance")]
        public Entity Entity { get; set; }
        [XmlElement(ElementName = "period", Namespace = "http://www.xbrl.org/2003/instance")]
        public Period Period { get; set; }
        [XmlAttribute(AttributeName = "id")]
        public string Id { get; set; }
    }
}