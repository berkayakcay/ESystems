using System.Xml.Serialization;

namespace Vol.ESystems.Core.Library.XBRL.Model
{
    [XmlRoot(ElementName = "ClaimedRoles", Namespace = "http://uri.etsi.org/01903/v1.3.2#")]
    public class ClaimedRoles
    {
        [XmlElement(ElementName = "ClaimedRole", Namespace = "http://uri.etsi.org/01903/v1.3.2#")]
        public string ClaimedRole { get; set; }
    }
}