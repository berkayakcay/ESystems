using System.Xml.Serialization;

namespace Vol.ESystems.Core.Library.XBRL.Model
{
    /// <summary>
    /// D�nem Ba�lang�c�
    /// </summary>
    [XmlRoot(ElementName = "periodCoveredStart", Namespace = "http://www.xbrl.org/int/gl/cor/2006-10-25")]
    public class PeriodCoveredStart
    {
        [XmlAttribute(AttributeName = "contextRef")]
        public string ContextRef { get; set; }
        [XmlText]
        public string Text { get; set; }
    }
}