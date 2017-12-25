using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Vol.ESystems.Core.Library.XBRL.Base
{
    public class XmlManager
    {
        public XmlManager()
        {
            
        }


        public string CreateXmlDocumentFile<T>(string FileName, T value) where T : class
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(T));
            try
            {
                using (StreamWriter streamWriter = new StreamWriter(FileName))
                    xmlSerializer.Serialize((TextWriter)streamWriter, (object)value);
                return this.ReadXmlDocumentFile(FileName);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public string ReadXmlDocumentFile(string FileName)
        {
            using (StreamReader streamReader = new StreamReader(FileName))
                return streamReader.ReadToEnd();
        }

        public string Serialize<T>(T value, string xslt = null) where T : class
        {
            if ((object)value == null)
                return (string)null;
            return Encoding.UTF8.GetString(this.XmlSerializeToByte<T>(value, xslt));
        }

        public T Deserialize<T>(string xmlContent) where T : class
        {
            xmlContent = xmlContent.Replace("&amp;", "&");
            xmlContent = xmlContent.Replace("&", "&amp;");
            return this.XmlDeserializeFromByte<T>(Encoding.UTF8.GetBytes(xmlContent));
        }

        private byte[] XmlSerializeToByte<T>(T value, string xslt = null) where T : class
        {
            if ((object)value == null)
                return (byte[])null;
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(T));
            using (MemoryStream memoryStream = new MemoryStream())
            {
                using (XmlWriter xmlWriter = XmlWriter.Create((Stream)memoryStream))
                {
                    if (!string.IsNullOrEmpty(xslt))
                        xmlWriter.WriteProcessingInstruction("xml-stylesheet", "type=\"text/xsl\" href=\"" + xslt + "\"");
                    xmlSerializer.Serialize(xmlWriter, (object)value);
                    return memoryStream.ToArray();
                }
            }
        }

        private T XmlDeserializeFromByte<T>(byte[] bytes) where T : class
        {
            using (MemoryStream memoryStream = new MemoryStream(bytes))
                return (T)new XmlSerializer(typeof(T)).Deserialize((Stream)memoryStream);
        }


    }
}
