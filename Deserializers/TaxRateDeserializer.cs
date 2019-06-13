using Shopping.Classes;
using System;
using System.IO;
using System.Xml.Serialization;

namespace Shopping
{
    public class TaxRateDeserializer
    {
        #region private

        private string path { get; set; }
        private string projectFolder { get; set; }
        private string file { get; set; }
        private XmlSerializer serializer { get; set; }
        private StreamReader reader { get; set; }

        private void Cleanup()
        {
            //cleanup any objects or services
        }

        #endregion

        #region public

        public TaxRates DeserializeTaxRates()
        {
            TaxRates taxrates = null;

            path = @"Resources\TaxRates.xml";
            projectFolder = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;
            file = Path.Combine(projectFolder, path);

            serializer = new XmlSerializer(typeof(TaxRates));

            reader = new StreamReader(file);
            taxrates = (TaxRates)serializer.Deserialize(reader);
            reader.Close();

            return taxrates;
        }

        #endregion
    }
}