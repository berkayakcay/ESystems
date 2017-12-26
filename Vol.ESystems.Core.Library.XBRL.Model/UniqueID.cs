using System.Xml.Serialization;

namespace Vol.ESystems.Core.Library.XBRL.Model
{

    /// <summary>
    /// Kontrol numaras�
    /// <para>
    /// �lgili dok�mana ait kontrol numaras� yaz�lacakt�r. Kontrol numaras�,ilgili hesap d�nemi i�erisinde birbirinden ayr� olarak olu�turulan defter dosyalar�n�n m�teselsilli�ini ve birbirleri ile ba�lanabilmelerini sa�lamaya y�nelik bir numarad�r.
    ///  </para>
    /// <example>
    /// <code>
    /// <gl-cor:uniqueID contextRef="journal_context">YEV201601000001</gl-cor:uniqueID>(Ocak ay�na ait tek par�a yevmiye defteri)
    /// <gl-cor:uniqueID contextRef = "journal_context" > YEV201602000002 </gl-cor:uniqueID>(�ubat ay�na ait tek par�a yevmiye defteri)
    /// <gl-cor:uniqueID contextRef = "journal_context" > YEV201602000003 </gl-cor:uniqueID>(�ubat ay�na ait iki par�a yevmiye defteri)
    /// <gl-cor:uniqueID contextRef = "journal_context" > YEV201603000004 </gl-cor:uniqueID>(Mart ay�na ait tek par�a yevmiye defteri)
    /// <gl-cor:uniqueID contextRef = "ledger_context" > KEB201601000001 </gl-cor:uniqueID>(Ocak ay�na ait tek par�a kebir defteri)
    /// <gl-cor:uniqueID contextRef = "ledger_context" > KEB201602000002 </gl-cor:uniqueID>(�ubat ay�na ait tek par�a kebir defteri)
    /// <gl-cor:uniqueID contextRef = "ledger_context" > KEB201602000003 </gl-cor:uniqueID>(�ubat ay�na ait iki par�a kebir defteri)
    /// <gl-cor:uniqueID contextRef = "ledger_context" > KEB201603000004 </gl-cor:uniqueID>(Mart ay�na ait tek par�a kebir defteri)
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