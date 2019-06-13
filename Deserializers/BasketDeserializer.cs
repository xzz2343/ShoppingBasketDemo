using Shopping.Classes;
using System;
using System.IO;
using System.Xml.Serialization;

namespace Shopping
{
    public class BasketDeserializer
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

        public Baskets DeserializeBaskets()
        {
            Baskets baskets = null;

            path = @"Resources\Baskets.xml";
            projectFolder = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;
            file = Path.Combine(projectFolder, path);

            serializer = new XmlSerializer(typeof(Baskets));

            reader = new StreamReader(file);
            baskets = (Baskets)serializer.Deserialize(reader);
            reader.Close();

            return baskets;
        }

        #endregion
    }
}