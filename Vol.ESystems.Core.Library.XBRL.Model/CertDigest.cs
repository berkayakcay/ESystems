using System.Xml.Serialization;

namespace Vol.ESystems.Core.Library.XBRL.Model
{
    [XmlRoot(ElementName = "CertDigest", Namespace = "http://uri.etsi.org/01903/v1.3.2#")]
    public class CertDigest
    {
        [XmlElement(ElementName = "DigestMethod", Namespace = "http://www.w3.org/2000/09/xmldsig#")]
        public DigestMethod DigestMethod { get; set; }
        [XmlElement(ElementName = "DigestValue", Namespace = "http://www.w3.org/2000/09/xmldsig#")]
        public string DigestValue { get; set; }
    }
}