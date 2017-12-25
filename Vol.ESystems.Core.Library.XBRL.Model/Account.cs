using System.Xml.Serialization;

namespace Vol.ESystems.Core.Library.XBRL.Model
{
    [XmlRoot(ElementName = "account", Namespace = "http://www.xbrl.org/int/gl/cor/2006-10-25")]
    public class Account
    {
        [XmlElement(ElementName = "accountMainID", Namespace = "http://www.xbrl.org/int/gl/cor/2006-10-25")]
        public AccountMainID AccountMainID { get; set; }
        [XmlElement(ElementName = "accountMainDescription", Namespace = "http://www.xbrl.org/int/gl/cor/2006-10-25")]
        public AccountMainDescription AccountMainDescription { get; set; }
        [XmlElement(ElementName = "accountSub", Namespace = "http://www.xbrl.org/int/gl/cor/2006-10-25")]
        public AccountSub AccountSub { get; set; }
    }
}