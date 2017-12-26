using System.Xml.Serialization;

namespace Vol.ESystems.Core.Library.XBRL.Model
{
    /// <summary>
    /// Doküman Bilgisi <br></br>
    /// Defterler hakkýnda tamamlayýcý bilgilerin yer aldýðý ana gruptur
    /// </summary>
    [XmlRoot(ElementName = "documentInfo", Namespace = "http://www.xbrl.org/int/gl/cor/2006-10-25")]
    public class DocumentInfo
    {
        [XmlElement(ElementName = "entriesType", Namespace = "http://www.xbrl.org/int/gl/cor/2006-10-25")]
        public EntriesType EntriesType { get; set; }

        [XmlElement(ElementName = "uniqueID", Namespace = "http://www.xbrl.org/int/gl/cor/2006-10-25")]
        public UniqueID UniqueID { get; set; }

        [XmlElement(ElementName = "language", Namespace = "http://www.xbrl.org/int/gl/cor/2006-10-25")]
        public Language Language { get; set; }

        [XmlElement(ElementName = "creationDate", Namespace = "http://www.xbrl.org/int/gl/cor/2006-10-25")]
        public CreationDate CreationDate { get; set; }

        [XmlElement(ElementName = "creator", Namespace = "http://www.xbrl.org/int/gl/bus/2006-10-25")]
        public Creator Creator { get; set; }

        [XmlElement(ElementName = "entriesComment", Namespace = "http://www.xbrl.org/int/gl/cor/2006-10-25")]
        public EntriesComment EntriesComment { get; set; }

        [XmlElement(ElementName = "periodCoveredStart", Namespace = "http://www.xbrl.org/int/gl/cor/2006-10-25")]
        public PeriodCoveredStart PeriodCoveredStart { get; set; }

        [XmlElement(ElementName = "periodCoveredEnd", Namespace = "http://www.xbrl.org/int/gl/cor/2006-10-25")]
        public PeriodCoveredEnd PeriodCoveredEnd { get; set; }

        [XmlElement(ElementName = "sourceApplication", Namespace = "http://www.xbrl.org/int/gl/bus/2006-10-25")]
        public SourceApplication SourceApplication { get; set; }
    }
}