using System.Xml.Serialization;

namespace Vol.ESystems.Core.Library.XBRL.Model
{
    /// <summary>
    /// Giriþi Yapan Kiþi
    /// </summary>
    [XmlRoot(ElementName = "enteredBy", Namespace = "http://www.xbrl.org/int/gl/cor/2006-10-25")]
    public class EnteredBy
    {
        [XmlAttribute(AttributeName = "contextRef")]
        public string ContextRef { get; set; }
        [XmlText]
        public string Text { get; set; }
    }
}