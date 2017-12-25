using System.Xml.Serialization;

namespace Vol.ESystems.Core.Library.XBRL.Model
{
    [XmlRoot(ElementName = "IssuerSerial", Namespace = "http://uri.etsi.org/01903/v1.3.2#")]
    public class IssuerSerial
    {
        [XmlElement(ElementName = "X509IssuerName", Namespace = "http://www.w3.org/2000/09/xmldsig#")]
        public string X509IssuerName { get; set; }
        [XmlElement(ElementName = "X509SerialNumber", Namespace = "http://www.w3.org/2000/09/xmldsig#")]
        public string X509SerialNumber { get; set; }
    }
}