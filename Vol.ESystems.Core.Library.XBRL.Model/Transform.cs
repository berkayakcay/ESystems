using System.Xml.Serialization;

namespace Vol.ESystems.Core.Library.XBRL.Model
{
    [XmlRoot(ElementName = "Transform", Namespace = "http://www.w3.org/2000/09/xmldsig#")]
    public class Transform
    {
        [XmlAttribute(AttributeName = "Algorithm")]
        public string Algorithm { get; set; }
    }
}