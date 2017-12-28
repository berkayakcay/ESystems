using System.Xml.Serialization;

namespace Vol.ESystems.Core.Library.XBRL.Model
{
    /// <summary>
    /// Yevmiye maddesine kaynak te�kil eden belgenin t�r�n� g�steren elemand�r.
    /// check: �ek
    /// invoice: Fatura
    /// order-customer: M��teri Sipari�Belgesi
    /// order-vendor: Sat�c�Sipari� Belgesi
    /// voucher: Senet
    /// shipment: Navlun
    /// receipt: Makbuz
    /// other:  Di�er
    /// </summary>
    [XmlRoot(ElementName = "documentType", Namespace = "http://www.xbrl.org/int/gl/cor/2006-10-25")]
    public class DocumentType
    {
        [XmlAttribute(AttributeName = "contextRef")]
        public string ContextRef { get; set; }
        [XmlText]
        public string Text { get; set; }
    }
}