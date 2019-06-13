using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Shopping.Classes
{
    [Serializable()]
    [XmlRoot("Baskets")]
    public class Baskets
    {
        [XmlElement("Basket")]
        public List<Basket> Basket { get; set; }
    }
}
