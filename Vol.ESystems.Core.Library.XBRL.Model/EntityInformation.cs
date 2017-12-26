using System.Collections.Generic;
using System.Xml.Serialization;

namespace Vol.ESystems.Core.Library.XBRL.Model
{
    /// <summary>
    /// Ýþletme Bilgileri Bölümü
    /// </summary>
    [XmlRoot(ElementName = "entityInformation", Namespace = "http://www.xbrl.org/int/gl/cor/2006-10-25")]
    public class EntityInformation
    {
        [XmlElement(ElementName = "entityPhoneNumber", Namespace = "http://www.xbrl.org/int/gl/bus/2006-10-25")]
        public EntityPhoneNumber EntityPhoneNumber { get; set; }
        [XmlElement(ElementName = "entityFaxNumberStructure", Namespace = "http://www.xbrl.org/int/gl/bus/2006-10-25")]
        public EntityFaxNumberStructure EntityFaxNumberStructure { get; set; }
        [XmlElement(ElementName = "entityEmailAddressStructure", Namespace = "http://www.xbrl.org/int/gl/bus/2006-10-25")]
        public EntityEmailAddressStructure EntityEmailAddressStructure { get; set; }
        [XmlElement(ElementName = "organizationIdentifiers", Namespace = "http://www.xbrl.org/int/gl/bus/2006-10-25")]
        public OrganizationIdentifiers OrganizationIdentifiers { get; set; }
        [XmlElement(ElementName = "organizationAddress", Namespace = "http://www.xbrl.org/int/gl/bus/2006-10-25")]
        public OrganizationAddress OrganizationAddress { get; set; }
        [XmlElement(ElementName = "entityWebSite", Namespace = "http://www.xbrl.org/int/gl/bus/2006-10-25")]
        public EntityWebSite EntityWebSite { get; set; }
        [XmlElement(ElementName = "businessDescription", Namespace = "http://www.xbrl.org/int/gl/bus/2006-10-25")]
        public BusinessDescription BusinessDescription { get; set; }
        [XmlElement(ElementName = "fiscalYearStart", Namespace = "http://www.xbrl.org/int/gl/bus/2006-10-25")]
        public FiscalYearStart FiscalYearStart { get; set; }
        [XmlElement(ElementName = "fiscalYearEnd", Namespace = "http://www.xbrl.org/int/gl/bus/2006-10-25")]
        public FiscalYearEnd FiscalYearEnd { get; set; }
        [XmlElement(ElementName = "accountantInformation", Namespace = "http://www.xbrl.org/int/gl/bus/2006-10-25")]
        public List<AccountantInformation> AccountantInformation { get; set; }
    }
}