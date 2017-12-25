using System.Xml.Serialization;

namespace Vol.ESystems.Core.Library.XBRL.Model
{
    [XmlRoot(ElementName = "Object", Namespace = "http://www.w3.org/2000/09/xmldsig#")]
    public class XBRLObject
    {
        [XmlElement(ElementName = "QualifyingProperties", Namespace = "http://uri.etsi.org/01903/v1.3.2#")]
        public QualifyingProperties QualifyingProperties { get; set; }
    }
}