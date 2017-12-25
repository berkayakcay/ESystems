using System.Xml.Serialization;

namespace Vol.ESystems.Core.Library.XBRL.Model
{
    [XmlRoot(ElementName = "SignerRole", Namespace = "http://uri.etsi.org/01903/v1.3.2#")]
    public class SignerRole
    {
        [XmlElement(ElementName = "ClaimedRoles", Namespace = "http://uri.etsi.org/01903/v1.3.2#")]
        public ClaimedRoles ClaimedRoles { get; set; }
    }
}