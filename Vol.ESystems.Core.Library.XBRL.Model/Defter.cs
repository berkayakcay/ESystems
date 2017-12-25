/* 
 Licensed under the Apache License, Version 2.0

 http://www.apache.org/licenses/LICENSE-2.0
 */
using System;
using System.Xml.Serialization;

namespace Vol.ESystems.Core.Library.XBRL.Model
{
    [XmlRoot(ElementName = "defter", Namespace = "http://www.edefter.gov.tr")]
    public class Defter
    {
        [XmlNamespaceDeclarations]
        public XmlSerializerNamespaces xmlns;

        [XmlAttribute(AttributeName = "schemaLocation", Namespace = "http://www.w3.org/2001/XMLSchema-instance")]
        public string SchemaLocation { get; set; }

        private Xbrl _Xbrl;

        public Defter()
        {
            this.xmlns = new XmlSerializerNamespaces();
            this.SchemaLocation = "http://www.edefter.gov.tr ../xsd/edefter.xsd";
            this.xmlns.Add("edefter", "http://www.edefter.gov.tr");
            this.xmlns.Add("xsi", "http://www.w3.org/2001/XMLSchema-instance");
            this.xmlns.Add("xbrli", "http://www.xbrl.org/2003/instance");

            this.Ds = "http://www.w3.org/2000/09/xmldsig#";
            this.Xades = "http://uri.etsi.org/01903/v1.3.2#";
            //this.Xsi = "http://www.w3.org/2001/XMLSchema-instance";
        }

        [XmlElement(ElementName = "xbrl", Namespace = "http://www.xbrl.org/2003/instance")]
        public virtual Xbrl Xbrl
        {
            get { return this._Xbrl; }
            set { this._Xbrl = value ?? new Xbrl(); }
        }

        [XmlElement(ElementName = "Signature", Namespace = "http://www.w3.org/2000/09/xmldsig#")]
        public Signature Signature { get; set; }


        [XmlAttribute(AttributeName = "edefter", Namespace = "http://www.w3.org/2000/xmlns/")]
        public string Edefter { get; set; }

        [XmlAttribute(AttributeName = "ds", Namespace = "http://www.w3.org/2000/xmlns/")]
        public string Ds { get; set; }

        [XmlAttribute(AttributeName = "xades", Namespace = "http://www.w3.org/2000/xmlns/")]
        public string Xades { get; set; }

        [XmlAttribute(AttributeName = "xsi", Namespace = "http://www.w3.org/2000/xmlns/")]
        public string Xsi { get; set; }
    }

}
