using System.Xml.Serialization;

namespace Vol.ESystems.Core.Library.XBRL.Model
{
    [XmlRoot(ElementName = "QualifyingProperties", Namespace = "http://uri.etsi.org/01903/v1.3.2#")]
    public class QualifyingProperties
    {
        [XmlElement(ElementName = "SignedProperties", Namespace = "http://uri.etsi.org/01903/v1.3.2#")]
        public SignedProperties SignedProperties { get; set; }
        [XmlAttribute(AttributeName = "Target")]
        public string Target { get; set; }
    }
}