using System.Xml.Serialization;

namespace Vol.ESystems.Core.Library.XBRL.Model
{
    [XmlRoot(ElementName = "SignedProperties", Namespace = "http://uri.etsi.org/01903/v1.3.2#")]
    public class SignedProperties
    {
        [XmlElement(ElementName = "SignedSignatureProperties", Namespace = "http://uri.etsi.org/01903/v1.3.2#")]
        public SignedSignatureProperties SignedSignatureProperties { get; set; }
        [XmlAttribute(AttributeName = "Id")]
        public string Id { get; set; }
    }
}