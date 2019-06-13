using System;
using System.Xml.Serialization;

namespace Shopping.Classes
{
    [Serializable]
    public class Item
    {
        [XmlAttribute("id")]
        public int ID { get; set; }

        [XmlAttribute("count")]
        public int Count { get; set; }
    }
}
