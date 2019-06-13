using System;
using System.Collections.Generic;
using System.Xml;
using System.Xml.Serialization;

namespace Shopping.Classes
{
    [Serializable()]
    public class Basket
    {
        [XmlAttribute("id")]
        public int ID { get; set; }

        [XmlElement("item")]
        public List<Item> Item { get; set; }

    }
}
