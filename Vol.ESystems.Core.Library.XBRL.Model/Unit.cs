using System.Xml.Serialization;

namespace Vol.ESystems.Core.Library.XBRL.Model
{
    [XmlRoot(ElementName = "unit", Namespace = "http://www.xbrl.org/2003/instance")]
    public class Unit
    {
        [XmlElement(ElementName = "measure", Namespace = "http://www.xbrl.org/2003/instance")]
        public string Measure { get; set; }
        [XmlAttribute(AttributeName = "id")]
        public string Id { get; set; }
    }
}