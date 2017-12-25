using System.Xml.Serialization;

namespace Vol.ESystems.Core.Library.XBRL.Model
{
    [XmlRoot(ElementName = "KeyValue", Namespace = "http://www.w3.org/2000/09/xmldsig#")]
    public class KeyValue
    {
        [XmlElement(ElementName = "RSAKeyValue", Namespace = "http://www.w3.org/2000/09/xmldsig#")]
        public RSAKeyValue RSAKeyValue { get; set; }
    }
}