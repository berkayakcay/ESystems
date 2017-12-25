using System.Xml.Serialization;

namespace Vol.ESystems.Core.Library.XBRL.Model
{
    [XmlRoot(ElementName = "entryDetail", Namespace = "http://www.xbrl.org/int/gl/cor/2006-10-25")]
    public class EntryDetail
    {
        [XmlElement(ElementName = "lineNumber", Namespace = "http://www.xbrl.org/int/gl/cor/2006-10-25")]
        public LineNumber LineNumber { get; set; }
        [XmlElement(ElementName = "lineNumberCounter", Namespace = "http://www.xbrl.org/int/gl/cor/2006-10-25")]
        public LineNumberCounter LineNumberCounter { get; set; }
        [XmlElement(ElementName = "account", Namespace = "http://www.xbrl.org/int/gl/cor/2006-10-25")]
        public Account Account { get; set; }
        [XmlElement(ElementName = "amount", Namespace = "http://www.xbrl.org/int/gl/cor/2006-10-25")]
        public Amount Amount { get; set; }
        [XmlElement(ElementName = "debitCreditCode", Namespace = "http://www.xbrl.org/int/gl/cor/2006-10-25")]
        public DebitCreditCode DebitCreditCode { get; set; }
        [XmlElement(ElementName = "postingDate", Namespace = "http://www.xbrl.org/int/gl/cor/2006-10-25")]
        public PostingDate PostingDate { get; set; }
        [XmlElement(ElementName = "documentReference", Namespace = "http://www.xbrl.org/int/gl/cor/2006-10-25")]
        public DocumentReference DocumentReference { get; set; }
        [XmlElement(ElementName = "detailComment", Namespace = "http://www.xbrl.org/int/gl/cor/2006-10-25")]
        public DetailComment DetailComment { get; set; }
        [XmlElement(ElementName = "paymentMethod", Namespace = "http://www.xbrl.org/int/gl/bus/2006-10-25")]
        public PaymentMethod PaymentMethod { get; set; }
        [XmlElement(ElementName = "documentType", Namespace = "http://www.xbrl.org/int/gl/cor/2006-10-25")]
        public DocumentType DocumentType { get; set; }
        [XmlElement(ElementName = "documentNumber", Namespace = "http://www.xbrl.org/int/gl/cor/2006-10-25")]
        public DocumentNumber DocumentNumber { get; set; }
        [XmlElement(ElementName = "documentDate", Namespace = "http://www.xbrl.org/int/gl/cor/2006-10-25")]
        public DocumentDate DocumentDate { get; set; }
    }
}