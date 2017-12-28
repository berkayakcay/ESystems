using System.Xml.Serialization;

namespace Vol.ESystems.Core.Library.XBRL.Model
{
    /// <summary>
    /// Kayýt Tanýtýcýsý
    /// <para>
    /// Kaydýn dayandýðý muhasebe fiþ numarasý yazýlacaktýr
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