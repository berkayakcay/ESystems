using System.Xml.Serialization;

namespace Vol.ESystems.Core.Library.XBRL.Model
{
    /// <summary>
    /// Yevmiye maddesine kaynak teþkil eden belgenin türünü gösteren elemandýr.
    /// check: Çek
    /// invoice: Fatura
    /// order-customer: Müþteri SipariþBelgesi
    /// order-vendor: SatýcýSipariþ Belgesi
    /// voucher: Senet
    /// shipment: Navlun
    /// receipt: Makbuz
    /// other:  Diðer
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