using System.Collections.Generic;
using System.Xml.Serialization;

namespace Vol.ESystems.Core.Library.XBRL.Model
{
    /// <summary>
    /// Muhasebe Kayýtlarý
    /// </summary>
    [XmlRoot(ElementName = "accountingEntries", Namespace = "http://www.xbrl.org/int/gl/cor/2006-10-25")]
    public class AccountingEntries
    {
        [XmlElement(ElementName = "documentInfo", Namespace = "http://www.xbrl.org/int/gl/cor/2006-10-25")]
        public DocumentInfo DocumentInfo { get; set; }
        [XmlElement(ElementName = "entityInformation", Namespace = "http://www.xbrl.org/int/gl/cor/2006-10-25")]
        public EntityInformation EntityInformation { get; set; }
        [XmlElement(ElementName = "entryHeader", Namespace = "http://www.xbrl.org/int/gl/cor/2006-10-25")]
        public List<EntryHeader> EntryHeader { get; set; }
    }
}