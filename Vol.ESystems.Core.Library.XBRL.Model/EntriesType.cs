using System.Xml.Serialization;

namespace Vol.ESystems.Core.Library.XBRL.Model
{
    /// <summary>
    /// Doküman Tipi
    /// <para>
    /// XBRL dokümanlarýndan hangisinin düzenlendiðini iþaret eder
    /// </para>
    /// <para>
    /// - account : Hesap Planý
    /// - balance : Bilanço
    /// - entries : Kayýtlar
    /// - journal : Yevmiye
    /// - ledger : Büyük Defter
    /// - assets : Varlýklar
    /// - trialBalance : Mizan
    /// - taxtables : Vergi Cetveli
    /// </para>
    /// <example>
    /// <code>
    /// <gl-cor:entriesType contextRef="journal_context">journal</gl-cor:entriesType>
    /// <gl-cor:entriesType contextRef = "ledger_context" > ledger </gl-cor:entriesType>
    /// </code>
    /// </example>
    /// </summary>
    [XmlRoot(ElementName = "entriesType", Namespace = "http://www.xbrl.org/int/gl/cor/2006-10-25")]
    public class EntriesType
    {
        [XmlAttribute(AttributeName = "contextRef")]
        public string ContextRef { get; set; }
        [XmlText]
        public string Text { get; set; }
    }
}