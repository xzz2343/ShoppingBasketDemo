using System;
using System.Xml;
using System.Xml.Serialization;

namespace Shopping.Classes
{
    [Serializable()]
    public class Product
    {
        [XmlAttribute("id")]
        public int ID { get; set; }

        [XmlElement("name")]
        public string Name { get; set; }

        [XmlElement("price")]
        public decimal Price { get; set; }

        [XmlElement("isTaxable")]
        public bool IsTaxable { get; set; }

        [XmlElement("isImported")]
        public bool IsImported { get; set; }
    }
}
