using System.Xml.Serialization;

namespace Vol.ESystems.Core.Library.XBRL.Model
{
    [XmlRoot(ElementName = "accountantContactPhone", Namespace = "http://www.xbrl.org/int/gl/bus/2006-10-25")]
    public class AccountantContactPhone
    {
        [XmlElement(ElementName = "accountantContactPhoneNumberDescription", Namespace = "http://www.xbrl.org/int/gl/bus/2006-10-25")]
        public AccountantContactPhoneNumberDescription AccountantContactPhoneNumberDescription { get; set; }
        [XmlElement(ElementName = "accountantContactPhoneNumber", Namespace = "http://www.xbrl.org/int/gl/bus/2006-10-25")]
        public AccountantContactPhoneNumber AccountantContactPhoneNumber { get; set; }
    }
}