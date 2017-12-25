using System.Xml.Serialization;

namespace Vol.ESystems.Core.Library.XBRL.Model
{
    [XmlRoot(ElementName = "entityFaxNumberStructure", Namespace = "http://www.xbrl.org/int/gl/bus/2006-10-25")]
    public class EntityFaxNumberStructure
    {
        [XmlElement(ElementName = "entityFaxNumber", Namespace = "http://www.xbrl.org/int/gl/bus/2006-10-25")]
        public EntityFaxNumber EntityFaxNumber { get; set; }
    }
}