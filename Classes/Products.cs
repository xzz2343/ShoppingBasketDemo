using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Shopping.Classes
{
    [Serializable()]
    [XmlRoot("Products")]
    public class Products
    {
        [XmlElement("Product")]
        public List<Product> Product { get; set; }
    }
}
