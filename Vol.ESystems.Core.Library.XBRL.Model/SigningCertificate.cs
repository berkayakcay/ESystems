using System.Xml.Serialization;

namespace Vol.ESystems.Core.Library.XBRL.Model
{
    [XmlRoot(ElementName = "SigningCertificate", Namespace = "http://uri.etsi.org/01903/v1.3.2#")]
    public class SigningCertificate
    {
        [XmlElement(ElementName = "Cert", Namespace = "http://uri.etsi.org/01903/v1.3.2#")]
        public Cert Cert { get; set; }
    }
}