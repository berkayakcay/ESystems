using System.Xml.Serialization;

namespace Vol.ESystems.Core.Library.XBRL.Model
{
    [XmlRoot(ElementName = "accountantContactFax", Namespace = "http://www.xbrl.org/int/gl/bus/2006-10-25")]
    public class AccountantContactFax
    {
        [XmlElement(ElementName = "accountantContactFaxNumber", Namespace = "http://www.xbrl.org/int/gl/bus/2006-10-25")]
        public AccountantContactFaxNumber AccountantContactFaxNumber { get; set; }
    }
}