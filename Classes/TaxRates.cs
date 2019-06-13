using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Shopping.Classes
{
    [Serializable()]
    [XmlRoot("TaxRates")]
    public class TaxRates
    {
        [XmlElement("TaxRate")]
        public List<TaxRate> TaxRate { get; set; }
    }
}
