using System.Collections.Generic;
using System.Xml.Serialization;

namespace Vol.ESystems.Core.Library.XBRL.Model
{

    /// <summary>
    /// Kayýt Bilgisi
    /// Muhasebe kayýtlarýný tutan defter bölümü
    /// Yevmiye ; Bir yevmiye maddesi
    /// Kebir   ; Bir ana hesap
    /// </summary>
    [XmlRoot(ElementName = "entryHeader", Namespace = "http://www.xbrl.org/int/gl/cor/2006-10-25")]
    public class EntryHeader
    {
        [XmlElement(ElementName = "enteredBy", Namespace = "http://www.xbrl.org/int/gl/cor/2006-10-25")]
        public EnteredBy EnteredBy { get; set; }
        [XmlElement(ElementName = "enteredDate", Namespace = "http://www.xbrl.org/int/gl/cor/2006-10-25")]
        public EnteredDate EnteredDate { get; set; }
        [XmlElement(ElementName = "entryNumber", Namespace = "http://www.xbrl.org/int/gl/cor/2006-10-25")]
        public EntryNumber EntryNumber { get; set; }
        [XmlElement(ElementName = "entryComment", Namespace = "http://www.xbrl.org/int/gl/cor/2006-10-25")]
        public EntryComment EntryComment { get; set; }
        [XmlElement(ElementName = "totalDebit", Namespace = "http://www.xbrl.org/int/gl/bus/2006-10-25")]
        public TotalDebit TotalDebit { get; set; }
        [XmlElement(ElementName = "totalCredit", Namespace = "http://www.xbrl.org/int/gl/bus/2006-10-25")]
        public TotalCredit TotalCredit { get; set; }
        [XmlElement(ElementName = "entryNumberCounter", Namespace = "http://www.xbrl.org/int/gl/cor/2006-10-25")]
        public EntryNumberCounter EntryNumberCounter { get; set; }
        [XmlElement(ElementName = "entryDetail", Namespace = "http://www.xbrl.org/int/gl/cor/2006-10-25")]
        public List<EntryDetail> EntryDetail { get; set; }
    }
}