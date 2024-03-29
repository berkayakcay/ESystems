using System.Xml.Serialization;

namespace Vol.ESystems.Core.Library.XBRL.Model
{
    /// <summary>
    /// Sat�r Numaras�
    /// </summary>
    [XmlRoot(ElementName = "lineNumber", Namespace = "http://www.xbrl.org/int/gl/cor/2006-10-25")]
    public class LineNumber
    {
        [XmlAttribute(AttributeName = "contextRef")]
        public string ContextRef { get; set; }
        [XmlText]
        public string Text { get; set; }
    }
}