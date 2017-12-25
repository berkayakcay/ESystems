using System.Xml.Serialization;

namespace Vol.ESystems.Core.Library.XBRL.Model
{
    [XmlRoot(ElementName = "amount", Namespace = "http://www.xbrl.org/int/gl/cor/2006-10-25")]
    public class Amount
    {
        [XmlAttribute(AttributeName = "contextRef")]
        public string ContextRef { get; set; }
        [XmlAttribute(AttributeName = "decimals")]
        public string Decimals { get; set; }
        [XmlAttribute(AttributeName = "unitRef")]
        public string UnitRef { get; set; }
        [XmlText]
        public string Text { get; set; }
    }
}