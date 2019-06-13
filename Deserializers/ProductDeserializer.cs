using Shopping.Classes;
using System;
using System.IO;
using System.Xml.Serialization;

namespace Shopping
{
    public class ProductDeserializer
    {
        #region private

        private string path { get; set; }
        private string projectFolder { get; set; }
        private string file { get; set; }
        private XmlSerializer serializer { get; set; }
        private StreamReader reader { get; set; }

        private void Cleanup()
        {
            throw new NotImplementedException();
        }

        #endregion

        #region public

        public Products DeserializeProducts()
        {
            Products products = null;

            path = @"Resources\Products.xml";
            projectFolder = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;
            file = Path.Combine(projectFolder, path);

            serializer = new XmlSerializer(typeof(Products));

            reader = new StreamReader(file);
            products = (Products)serializer.Deserialize(reader);
            reader.Close();

            return products;
        }

        #endregion
    }
}