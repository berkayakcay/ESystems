using System.Xml.Serialization;

namespace Vol.ESystems.Core.Library.XBRL.Model
{
    /// <summary>
    /// Kay�t Tan�t�c�s�
    /// <para>
    /// Kayd�n dayand��� muhasebe fi� numaras� yaz�lacakt�r
    /// </para>
    /// </summary>
    [XmlRoot(ElementName = "entryNumber", Namespace = "http://www.xbrl.org/int/gl/cor/2006-10-25")]
    public class EntryNumber
    {
        [XmlAttribute(AttributeName = "contextRef")]
        public string ContextRef { get; set; }
        [XmlText]
        public string Text { get; set; }
    }
}