using System.Xml.Serialization;

namespace Vol.ESystems.Core.Library.XBRL.Model
{
    /// <summary>
    /// Kurum VKN
    /// </summary>
    [XmlRoot(ElementName = "identifier", Namespace = "http://www.xbrl.org/2003/instance")]
    public class Identifier
    {
        [XmlAttribute(AttributeName = "scheme")]
        public string Scheme { get; set; }

        /// <summary>
        /// Kurum VKN
        /// </summary>
        [XmlText]
        public string Text { get; set; }
    }
}