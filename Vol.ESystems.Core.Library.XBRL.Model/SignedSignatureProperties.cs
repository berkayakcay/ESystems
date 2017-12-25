using System.Xml.Serialization;

namespace Vol.ESystems.Core.Library.XBRL.Model
{
    [XmlRoot(ElementName = "SignedSignatureProperties", Namespace = "http://uri.etsi.org/01903/v1.3.2#")]
    public class SignedSignatureProperties
    {
        [XmlElement(ElementName = "SigningTime", Namespace = "http://uri.etsi.org/01903/v1.3.2#")]
        public string SigningTime { get; set; }
        [XmlElement(ElementName = "SigningCertificate", Namespace = "http://uri.etsi.org/01903/v1.3.2#")]
        public SigningCertificate SigningCertificate { get; set; }
        [XmlElement(ElementName = "SignerRole", Namespace = "http://uri.etsi.org/01903/v1.3.2#")]
        public SignerRole SignerRole { get; set; }
    }
}