using System.Xml.Serialization;

namespace Vol.ESystems.Core.Library.XBRL.Model
{
    [XmlRoot(ElementName = "organizationIdentifiers", Namespace = "http://www.xbrl.org/int/gl/bus/2006-10-25")]
    public class OrganizationIdentifiers
    {
        [XmlElement(ElementName = "organizationIdentifier", Namespace = "http://www.xbrl.org/int/gl/bus/2006-10-25")]
        public OrganizationIdentifier OrganizationIdentifier { get; set; }
        [XmlElement(ElementName = "organizationDescription", Namespace = "http://www.xbrl.org/int/gl/bus/2006-10-25")]
        public OrganizationDescription OrganizationDescription { get; set; }
    }
}