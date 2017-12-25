using System.Xml.Serialization;

namespace Vol.ESystems.Core.Library.XBRL.Model
{
    [XmlRoot(ElementName = "entityEmailAddressStructure", Namespace = "http://www.xbrl.org/int/gl/bus/2006-10-25")]
    public class EntityEmailAddressStructure
    {
        [XmlElement(ElementName = "entityEmailAddress", Namespace = "http://www.xbrl.org/int/gl/bus/2006-10-25")]
        public EntityEmailAddress EntityEmailAddress { get; set; }
    }
}