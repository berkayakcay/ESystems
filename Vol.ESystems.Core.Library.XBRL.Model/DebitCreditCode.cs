using System.Xml.Serialization;

namespace Vol.ESystems.Core.Library.XBRL.Model
{
    /// <summary>
    /// Sadece bor� i�in Dalacak i�in C g�stergelerden birisi kullan�lacakt�r
    /// </summary>
    [XmlRoot(ElementName = "debitCreditCode", Namespace = "http://www.xbrl.org/int/gl/cor/2006-10-25")]
    public class DebitCreditCode
    {
        [XmlAttribute(AttributeName = "contextRef")]
        public string ContextRef { get; set; }
        [XmlText]
        public string Text { get; set; }
    }
}