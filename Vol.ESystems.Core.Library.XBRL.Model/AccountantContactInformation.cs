using System.Xml.Serialization;

namespace Vol.ESystems.Core.Library.XBRL.Model
{
    [XmlRoot(ElementName = "accountantContactInformation", Namespace = "http://www.xbrl.org/int/gl/bus/2006-10-25")]
    public class AccountantContactInformation
    {
        [XmlElement(ElementName = "accountantContactPhone", Namespace = "http://www.xbrl.org/int/gl/bus/2006-10-25")]
        public AccountantContactPhone AccountantContactPhone { get; set; }
        [XmlElement(ElementName = "accountantContactFax", Namespace = "http://www.xbrl.org/int/gl/bus/2006-10-25")]
        public AccountantContactFax AccountantContactFax { get; set; }
        [XmlElement(ElementName = "accountantContactEmail", Namespace = "http://www.xbrl.org/int/gl/bus/2006-10-25")]
        public AccountantContactEmail AccountantContactEmail { get; set; }
    }
}