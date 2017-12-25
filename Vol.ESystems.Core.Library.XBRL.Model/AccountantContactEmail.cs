using System.Xml.Serialization;

namespace Vol.ESystems.Core.Library.XBRL.Model
{
    [XmlRoot(ElementName = "accountantContactEmail", Namespace = "http://www.xbrl.org/int/gl/bus/2006-10-25")]
    public class AccountantContactEmail
    {
        [XmlElement(ElementName = "accountantContactEmailAddress", Namespace = "http://www.xbrl.org/int/gl/bus/2006-10-25")]
        public AccountantContactEmailAddress AccountantContactEmailAddress { get; set; }
    }
}