using System.Xml.Serialization;

namespace Vol.ESystems.Core.Library.XBRL.Model
{
    [XmlRoot(ElementName = "RSAKeyValue", Namespace = "http://www.w3.org/2000/09/xmldsig#")]
    public class RSAKeyValue
    {
        [XmlElement(ElementName = "Modulus", Namespace = "http://www.w3.org/2000/09/xmldsig#")]
        public string Modulus { get; set; }
        [XmlElement(ElementName = "Exponent", Namespace = "http://www.w3.org/2000/09/xmldsig#")]
        public string Exponent { get; set; }
    }
}