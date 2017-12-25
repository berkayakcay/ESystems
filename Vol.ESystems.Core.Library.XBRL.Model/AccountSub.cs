using System.Xml.Serialization;

namespace Vol.ESystems.Core.Library.XBRL.Model
{
    [XmlRoot(ElementName = "accountSub", Namespace = "http://www.xbrl.org/int/gl/cor/2006-10-25")]
    public class AccountSub
    {
        [XmlElement(ElementName = "accountSubDescription", Namespace = "http://www.xbrl.org/int/gl/cor/2006-10-25")]
        public AccountSubDescription AccountSubDescription { get; set; }
        [XmlElement(ElementName = "accountSubID", Namespace = "http://www.xbrl.org/int/gl/cor/2006-10-25")]
        public AccountSubID AccountSubID { get; set; }
    }
}