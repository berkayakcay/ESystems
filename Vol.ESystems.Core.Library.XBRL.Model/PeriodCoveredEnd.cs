using System.Xml.Serialization;

namespace Vol.ESystems.Core.Library.XBRL.Model
{
    /// <summary>
    /// D�nem Sonu
    /// </summary>
    [XmlRoot(ElementName = "periodCoveredEnd", Namespace = "http://www.xbrl.org/int/gl/cor/2006-10-25")]
    public class PeriodCoveredEnd
    {
        [XmlAttribute(AttributeName = "contextRef")]
        public string ContextRef { get; set; }
        [XmlText]
        public string Text { get; set; }
    }
}