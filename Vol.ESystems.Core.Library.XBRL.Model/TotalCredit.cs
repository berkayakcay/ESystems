using System.Xml.Serialization;

namespace Vol.ESystems.Core.Library.XBRL.Model
{
    /// <summary>
    /// Toplam Alacak
    /// </summary>
    [XmlRoot(ElementName = "totalCredit", Namespace = "http://www.xbrl.org/int/gl/bus/2006-10-25")]
    public class TotalCredit
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