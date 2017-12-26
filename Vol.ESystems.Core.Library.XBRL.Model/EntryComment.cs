using System.Xml.Serialization;

namespace Vol.ESystems.Core.Library.XBRL.Model
{
    /// <summary>
    /// Dok�man A��klamas�
    /// </summary>
    [XmlRoot(ElementName = "entryComment", Namespace = "http://www.xbrl.org/int/gl/cor/2006-10-25")]
    public class EntryComment
    {
        [XmlAttribute(AttributeName = "contextRef")]
        public string ContextRef { get; set; }
        [XmlText]
        public string Text { get; set; }
    }
}