using System.Xml.Serialization;

namespace Vol.ESystems.Core.Library.XBRL.Model
{
    /// <summary>
    /// Dok�man Tipi
    /// <para>
    /// XBRL dok�manlar�ndan hangisinin d�zenlendi�ini i�aret eder
    /// </para>
    /// <para>
    /// - account : Hesap Plan�
    /// - balance : Bilan�o
    /// - entries : Kay�tlar
    /// - journal : Yevmiye
    /// - ledger : B�y�k Defter
    /// - assets : Varl�klar
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