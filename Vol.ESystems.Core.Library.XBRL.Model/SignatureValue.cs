using System.Xml.Serialization;

namespace Vol.ESystems.Core.Library.XBRL.Model
{
    [XmlRoot(ElementName = "SignatureValue", Namespace = "http://www.w3.org/2000/09/xmldsig#")]
    public class SignatureValue
    {
        [XmlAttribute(AttributeName = "Id")]
        public string Id { get; set; }
        [XmlText]
        public string Text { get; set; }
    }
}