using System;
using System.Xml.Serialization;
using System.Collections.Generic;
namespace Vol.ESystems.Core.Library.XBRL.Model
{
    

    [XmlRoot(ElementName = "numberOfEntries", Namespace = "http://www.xbrl.org/int/gl/bus/2006-10-25")]
    public class NumberOfEntries
    {
        [XmlAttribute(AttributeName = "contextRef")]
        public string ContextRef { get; set; }
        [XmlAttribute(AttributeName = "unitRef")]
        public string UnitRef { get; set; }
        [XmlText]
        public string Text { get; set; }
    }
}
