using System.Xml.Serialization;

namespace Vol.ESystems.Core.Library.XBRL.Model
{
    [XmlRoot(ElementName = "organizationAddressCity", Namespace = "http://www.xbrl.org/int/gl/bus/2006-10-25")]
    public class OrganizationAddressCity
    {
        [XmlAttribute(AttributeName = "contextRef")]
        public string ContextRef { get; set; }
        [XmlText]
        public string Text { get; set; }
    }
}