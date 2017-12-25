using System.Xml.Serialization;

namespace Vol.ESystems.Core.Library.XBRL.Model
{
    [XmlRoot(ElementName = "Signature", Namespace = "http://www.w3.org/2000/09/xmldsig#")]
    public class Signature
    {
        [XmlElement(ElementName = "SignedInfo", Namespace = "http://www.w3.org/2000/09/xmldsig#")]
        public SignedInfo SignedInfo { get; set; }
        [XmlElement(ElementName = "SignatureValue", Namespace = "http://www.w3.org/2000/09/xmldsig#")]
        public SignatureValue SignatureValue { get; set; }
        [XmlElement(ElementName = "KeyInfo", Namespace = "http://www.w3.org/2000/09/xmldsig#")]
        public KeyInfo KeyInfo { get; set; }
        [XmlElement(ElementName = "Object", Namespace = "http://www.w3.org/2000/09/xmldsig#")]
        public XBRLObject Object { get; set; }
        [XmlAttribute(AttributeName = "Id")]
        public string Id { get; set; }
    }
}