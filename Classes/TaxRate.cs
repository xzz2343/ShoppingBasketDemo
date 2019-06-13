using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Shopping.Classes
{
    [Serializable]
    public class TaxRate
    {
        [XmlAttribute("id")]
        public int ID { get; set; }

        [XmlElement("type")]
        public string Type { get; set; }


        [XmlElement("rate")]
        public decimal Rate { get; set; }
    }
}
