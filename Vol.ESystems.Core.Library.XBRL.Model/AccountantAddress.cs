using System.Xml.Serialization;

namespace Vol.ESystems.Core.Library.XBRL.Model
{
    [XmlRoot(ElementName = "accountantAddress", Namespace = "http://www.xbrl.org/int/gl/bus/2006-10-25")]
    public class AccountantAddress
    {
        [XmlElement(ElementName = "accountantBuildingNumber", Namespace = "http://www.xbrl.org/int/gl/bus/2006-10-25")]
        public AccountantBuildingNumber AccountantBuildingNumber { get; set; }
        [XmlElement(ElementName = "accountantStreet", Namespace = "http://www.xbrl.org/int/gl/bus/2006-10-25")]
        public AccountantStreet AccountantStreet { get; set; }
        [XmlElement(ElementName = "accountantAddressStreet2", Namespace = "http://www.xbrl.org/int/gl/bus/2006-10-25")]
        public AccountantAddressStreet2 AccountantAddressStreet2 { get; set; }
        [XmlElement(ElementName = "accountantCity", Namespace = "http://www.xbrl.org/int/gl/bus/2006-10-25")]
        public AccountantCity AccountantCity { get; set; }
        [XmlElement(ElementName = "accountantCountry", Namespace = "http://www.xbrl.org/int/gl/bus/2006-10-25")]
        public AccountantCountry AccountantCountry { get; set; }
        [XmlElement(ElementName = "accountantZipOrPostalCode", Namespace = "http://www.xbrl.org/int/gl/bus/2006-10-25")]
        public AccountantZipOrPostalCode AccountantZipOrPostalCode { get; set; }
    }
}