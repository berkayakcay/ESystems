using System.Xml.Serialization;

namespace Vol.ESystems.Core.Library.XBRL.Model
{
    /// <summary>
    /// Dil
    /// <para>
    /// Kod numaralarý ISO 639-1988 dil kodlarýyla uyuþmalýdýr.
    /// </para>
    /// </summary>
    [XmlRoot(ElementName = "language", Namespace = "http://www.xbrl.org/int/gl/cor/2006-10-25")]
    public class Language
    {
        [XmlAttribute(AttributeName = "contextRef")]
        public string ContextRef { get; set; }
        [XmlText]
        public string Text { get; set; }
    }
}