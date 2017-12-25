using System.Collections.Generic;
using System.Xml.Serialization;

namespace Vol.ESystems.Core.Library.XBRL.Model
{
    [XmlRoot(ElementName = "xbrl", Namespace = "http://www.xbrl.org/2003/instance")]
    public class Xbrl
    {
        public Xbrl()
        {
            this.Glbus = "http://www.xbrl.org/int/gl/bus/2006-10-25";
            this.Glcor = "http://www.xbrl.org/int/gl/cor/2006-10-25";
            this.Glplt = "http://www.xbrl.org/int/gl/plt/2006-10-25";
            this.Iso4217 = "http://www.xbrl.org/2003/iso4217";
            this.Iso639 = "http://www.xbrl.org/2005/iso639";
            this.Link = "http://www.xbrl.org/2003/linkbase";
            this.Xbrli = "http://www.xbrl.org/2003/instance";
            this.Xlink = "http://www.w3.org/1999/xlink";
            this.SchemaLocation = "http://www.xbrl.org/int/gl/plt/2006-10-25 ../xsd/2006-10-25/plt/case-c-b/gl-plt-2006-10-25.xsd";
        }

        [XmlElement(ElementName = "schemaRef", Namespace = "http://www.xbrl.org/2003/linkbase")]
        public SchemaRef SchemaRef { get; set; }

        [XmlElement(ElementName = "context", Namespace = "http://www.xbrl.org/2003/instance")]
        public Context Context { get; set; }

        [XmlElement(ElementName = "unit", Namespace = "http://www.xbrl.org/2003/instance")]
        public List<Unit> Unit { get; set; }

        [XmlElement(ElementName = "accountingEntries", Namespace = "http://www.xbrl.org/int/gl/cor/2006-10-25")]
        public AccountingEntries AccountingEntries { get; set; }

        [XmlAttribute(AttributeName = "gl-bus", Namespace = "http://www.w3.org/2000/xmlns/")]
        public string Glbus { get; set; }

        [XmlAttribute(AttributeName = "gl-cor", Namespace = "http://www.w3.org/2000/xmlns/")]
        public string Glcor { get; set; }

        [XmlAttribute(AttributeName = "gl-plt", Namespace = "http://www.w3.org/2000/xmlns/")]
        public string Glplt { get; set; }

        [XmlAttribute(AttributeName = "iso4217", Namespace = "http://www.w3.org/2000/xmlns/")]
        public string Iso4217 { get; set; }

        [XmlAttribute(AttributeName = "iso639", Namespace = "http://www.w3.org/2000/xmlns/")]
        public string Iso639 { get; set; }

        [XmlAttribute(AttributeName = "link", Namespace = "http://www.w3.org/2000/xmlns/")]
        public string Link { get; set; }

        [XmlAttribute(AttributeName = "xbrli", Namespace = "http://www.w3.org/2000/xmlns/")]
        public string Xbrli { get; set; }

        [XmlAttribute(AttributeName = "xlink", Namespace = "http://www.w3.org/2000/xmlns/")]
        public string Xlink { get; set; }

        [XmlAttribute(AttributeName = "schemaLocation", Namespace = "http://www.w3.org/2001/XMLSchema-instance")]
        public string SchemaLocation { get; set; }
    }
}