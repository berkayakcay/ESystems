using System.Xml.Serialization;

namespace Vol.ESystems.Core.Library.XBRL.Model
{
    [XmlRoot(ElementName = "schemaRef", Namespace = "http://www.xbrl.org/2003/linkbase")]
    public class SchemaRef
    {
        [XmlAttribute(AttributeName = "href", Namespace = "http://www.w3.org/1999/xlink")]
        public string Href { get; set; }
        [XmlAttribute(AttributeName = "type", Namespace = "http://www.w3.org/1999/xlink")]
        public string Type { get; set; }
    }
}