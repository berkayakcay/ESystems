using System.Xml.Serialization;

namespace Vol.ESystems.Core.Library.XBRL.Model
{
    [XmlRoot(ElementName = "accountantInformation", Namespace = "http://www.xbrl.org/int/gl/bus/2006-10-25")]
    public class AccountantInformation
    {
        [XmlElement(ElementName = "accountantName", Namespace = "http://www.xbrl.org/int/gl/bus/2006-10-25")]
        public AccountantName AccountantName { get; set; }
        [XmlElement(ElementName = "accountantAddress", Namespace = "http://www.xbrl.org/int/gl/bus/2006-10-25")]
        public AccountantAddress AccountantAddress { get; set; }
        [XmlElement(ElementName = "accountantEngagementTypeDescription", Namespace = "http://www.xbrl.org/int/gl/bus/2006-10-25")]
        public AccountantEngagementTypeDescription AccountantEngagementTypeDescription { get; set; }
        [XmlElement(ElementName = "accountantContactInformation", Namespace = "http://www.xbrl.org/int/gl/bus/2006-10-25")]
        public AccountantContactInformation AccountantContactInformation { get; set; }
    }
}