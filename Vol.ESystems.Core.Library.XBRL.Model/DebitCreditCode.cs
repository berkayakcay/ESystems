using System.Xml.Serialization;

namespace Vol.ESystems.Core.Library.XBRL.Model
{
    /// <summary>
    /// Sadece borç için Dalacak için C göstergelerden birisi kullanýlacaktýr
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