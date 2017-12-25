using System.Xml.Serialization;

namespace Vol.ESystems.Core.Library.XBRL.Model
{
    [XmlRoot(ElementName = "organizationAddress", Namespace = "http://www.xbrl.org/int/gl/bus/2006-10-25")]
    public class OrganizationAddress
    {
        [XmlElement(ElementName = "organizationBuildingNumber", Namespace = "http://www.xbrl.org/int/gl/bus/2006-10-25")]
        public OrganizationBuildingNumber OrganizationBuildingNumber { get; set; }
        [XmlElement(ElementName = "organizationAddressStreet", Namespace = "http://www.xbrl.org/int/gl/bus/2006-10-25")]
        public OrganizationAddressStreet OrganizationAddressStreet { get; set; }
        [XmlElement(ElementName = "organizationAddressStreet2", Namespace = "http://www.xbrl.org/int/gl/bus/2006-10-25")]
        public OrganizationAddressStreet2 OrganizationAddressStreet2 { get; set; }
        [XmlElement(ElementName = "organizationAddressCity", Namespace = "http://www.xbrl.org/int/gl/bus/2006-10-25")]
        public OrganizationAddressCity OrganizationAddressCity { get; set; }
        [XmlElement(ElementName = "organizationAddressZipOrPostalCode", Namespace = "http://www.xbrl.org/int/gl/bus/2006-10-25")]
        public OrganizationAddressZipOrPostalCode OrganizationAddressZipOrPostalCode { get; set; }
        [XmlElement(ElementName = "organizationAddressCountry", Namespace = "http://www.xbrl.org/int/gl/bus/2006-10-25")]
        public OrganizationAddressCountry OrganizationAddressCountry { get; set; }
    }
}