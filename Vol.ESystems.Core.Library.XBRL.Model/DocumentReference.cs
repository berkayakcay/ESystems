using System.Xml.Serialization;

namespace Vol.ESystems.Core.Library.XBRL.Model
{
    /// <summary>
    /// Belgenin ili�kili oldu�u muhasebe fi� numaras� yaz�lacakt�r. 
    /// </summary>
    [XmlRoot(ElementName = "documentReference", Namespace = "http://www.xbrl.org/int/gl/cor/2006-10-25")]
    public class DocumentReference
    {
        [XmlAttribute(AttributeName = "contextRef")]
        public string ContextRef { get; set; }
        [XmlText]
        public string Text { get; set; }
    }
}