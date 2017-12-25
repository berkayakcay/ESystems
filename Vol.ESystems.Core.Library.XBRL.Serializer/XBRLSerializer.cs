using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Vol.ESystems.Core.Library.XBRL.Base;
using Vol.ESystems.Core.Library.XBRL.Model;

namespace Vol.ESystems.Core.Library.XBRL.Serializer
{
    public class XBRLSerializer
    {
        public XBRLSerializer()
        {
            
        }

        public string SerializeFromDefter(Defter xbrlDefter)
        {
            List<Defter> xbrlDefters = new List<Defter>();
            Defter xbrlDefter1 = xbrlDefter;
            xbrlDefters.Add(xbrlDefter1);
            return this.Serialize(xbrlDefters);
        }

        public string Serialize(List<Defter> xbrlDefters)
        {
            XmlManager xmlManager = new XmlManager();
            string str1 = string.Empty;
            foreach (Defter xbrlDefter in xbrlDefters)
            {
                string empty = string.Empty;
                string content;
                try
                {
                    content = xmlManager.Serialize<Defter>(xbrlDefter, (string)null);
                }
                catch (Exception exception)
                {
                    throw new Exception("E-DEFTER SERIALIZE EDILEMEDI! => " + exception.Message);
                }
                string str2 = this.CleanXmlContent(content);
                str1 = str1 + str2 + Environment.NewLine;
            }
            return str1;
        }

        public Defter DeserializeFromContent(string invoiceXmlContent)
        {
            XmlManager xmlManager = new XmlManager();
            Defter xbrlDefter;
            try
            {
                xbrlDefter = xmlManager.Deserialize<Defter>(invoiceXmlContent);
            }
            catch (Exception exception)
            {
                try
                {
                    XDocument xdocument = XDocument.Parse(invoiceXmlContent);
                    XElement xelement = xdocument.Elements().First<XElement>().Element(XName.Get("LineCountNumeric", "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"));
                    xelement.Value = int.Parse(xelement.Value.Substring(0, xelement.Value.IndexOf("."))).ToString();
                    xbrlDefter = xmlManager.Deserialize<Defter>(xdocument.ToString());
                }
                catch (Exception exception1)
                {
                    throw new Exception("XML DESERIALIZE EDILEMEDI! => " + exception.Message);
                }
            }
            return xbrlDefter;
        }

        public string CleanXmlContent(string content)
        {
            string empty = string.Empty;
            int startIndex = content.IndexOf("<?");
            int num = 0;
            if (startIndex >= 0)
                num = content.IndexOf("?>", startIndex);
            return startIndex < 0 || num < 0 ? content : content.Substring(num + 2, content.Length - (num + 2));
        }
    }
}
