using System.Xml.Serialization;

namespace Vol.ESystems.Core.Library.XBRL.Model
{
    [XmlRoot(ElementName = "entityPhoneNumber", Namespace = "http://www.xbrl.org/int/gl/bus/2006-10-25")]
    public class EntityPhoneNumber
    {
        [XmlElement(ElementName = "phoneNumberDescription", Namespace = "http://www.xbrl.org/int/gl/bus/2006-10-25")]
        public PhoneNumberDescription PhoneNumberDescription { get; set; }
        [XmlElement(ElementName = "phoneNumber", Namespace = "http://www.xbrl.org/int/gl/bus/2006-10-25")]
        public PhoneNumber PhoneNumber { get; set; }
    }
}