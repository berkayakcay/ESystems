using System.Xml.Serialization;

namespace Vol.ESystems.Core.Library.XBRL.Model
{

    /// <summary>
    /// Kontrol numarasý
    /// <para>
    /// Ýlgili dokümana ait kontrol numarasý yazýlacaktýr. Kontrol numarasý,ilgili hesap dönemi içerisinde birbirinden ayrý olarak oluþturulan defter dosyalarýnýn müteselsilliðini ve birbirleri ile baðlanabilmelerini saðlamaya yönelik bir numaradýr.
    ///  </para>
    /// <example>
    /// <code>
    /// <gl-cor:uniqueID contextRef="journal_context">YEV201601000001</gl-cor:uniqueID>(Ocak ayýna ait tek parça yevmiye defteri)
    /// <gl-cor:uniqueID contextRef = "journal_context" > YEV201602000002 </gl-cor:uniqueID>(Þubat ayýna ait tek parça yevmiye defteri)
    /// <gl-cor:uniqueID contextRef = "journal_context" > YEV201602000003 </gl-cor:uniqueID>(Þubat ayýna ait iki parça yevmiye defteri)
    /// <gl-cor:uniqueID contextRef = "journal_context" > YEV201603000004 </gl-cor:uniqueID>(Mart ayýna ait tek parça yevmiye defteri)
    /// <gl-cor:uniqueID contextRef = "ledger_context" > KEB201601000001 </gl-cor:uniqueID>(Ocak ayýna ait tek parça kebir defteri)
    /// <gl-cor:uniqueID contextRef = "ledger_context" > KEB201602000002 </gl-cor:uniqueID>(Þubat ayýna ait tek parça kebir defteri)
    /// <gl-cor:uniqueID contextRef = "ledger_context" > KEB201602000003 </gl-cor:uniqueID>(Þubat ayýna ait iki parça kebir defteri)
    /// <gl-cor:uniqueID contextRef = "ledger_context" > KEB201603000004 </gl-cor:uniqueID>(Mart ayýna ait tek parça kebir defteri)
    /// </code>
    /// </example>
    /// </summary>
    [XmlRoot(ElementName = "uniqueID", Namespace = "http://www.xbrl.org/int/gl/cor/2006-10-25")]
    public class UniqueID
    {
        [XmlAttribute(AttributeName = "contextRef")]
        public string ContextRef { get; set; }
        [XmlText]
        public string Text { get; set; }
    }
}