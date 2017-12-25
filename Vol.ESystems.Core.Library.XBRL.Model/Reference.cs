using System.Xml.Serialization;

namespace Vol.ESystems.Core.Library.XBRL.Model
{
    [XmlRoot(ElementName = "Reference", Namespace = "http://www.w3.org/2000/09/xmldsig#")]
    public class Reference
    {
        [XmlElement(ElementName = "Transforms", Namespace = "http://www.w3.org/2000/09/xmldsig#")]
        public Transforms Transforms { get; set; }
        [XmlElement(ElementName = "DigestMethod", Namespace = "http://www.w3.org/2000/09/xmldsig#")]
        public DigestMethod DigestMethod { get; set; }
        [XmlElement(ElementName = "DigestValue", Namespace = "http://www.w3.org/2000/09/xmldsig#")]
        public string DigestValue { get; set; }
        [XmlAttribute(AttributeName = "URI")]
        public string URI { get; set; }
        [XmlAttribute(AttributeName = "Id")]
        public string Id { get; set; }

        [XmlAttribute(AttributeName = "Type")]
        public string Type { get; set; }
    }
}