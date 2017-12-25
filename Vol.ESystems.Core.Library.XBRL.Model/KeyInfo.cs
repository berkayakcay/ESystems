using System.Xml.Serialization;

namespace Vol.ESystems.Core.Library.XBRL.Model
{
    [XmlRoot(ElementName = "KeyInfo", Namespace = "http://www.w3.org/2000/09/xmldsig#")]
    public class KeyInfo
    {
        [XmlElement(ElementName = "KeyValue", Namespace = "http://www.w3.org/2000/09/xmldsig#")]
        public KeyValue KeyValue { get; set; }
        [XmlElement(ElementName = "X509Data", Namespace = "http://www.w3.org/2000/09/xmldsig#")]
        public X509Data X509Data { get; set; }
    }
}