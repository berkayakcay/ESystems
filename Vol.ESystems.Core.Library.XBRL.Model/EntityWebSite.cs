using System.Xml.Serialization;

namespace Vol.ESystems.Core.Library.XBRL.Model
{
    [XmlRoot(ElementName = "entityWebSite", Namespace = "http://www.xbrl.org/int/gl/bus/2006-10-25")]
    public class EntityWebSite
    {
        [XmlElement(ElementName = "webSiteURL", Namespace = "http://www.xbrl.org/int/gl/bus/2006-10-25")]
        public WebSiteURL WebSiteURL { get; set; }
    }
}