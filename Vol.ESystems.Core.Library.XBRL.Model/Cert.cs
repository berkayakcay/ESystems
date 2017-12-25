using System.Xml.Serialization;

namespace Vol.ESystems.Core.Library.XBRL.Model
{
    [XmlRoot(ElementName = "Cert", Namespace = "http://uri.etsi.org/01903/v1.3.2#")]
    public class Cert
    {
        [XmlElement(ElementName = "CertDigest", Namespace = "http://uri.etsi.org/01903/v1.3.2#")]
        public CertDigest CertDigest { get; set; }
        [XmlElement(ElementName = "IssuerSerial", Namespace = "http://uri.etsi.org/01903/v1.3.2#")]
        public IssuerSerial IssuerSerial { get; set; }
    }
}