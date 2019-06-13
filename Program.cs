using Shopping.Classes;
using System;
using System.IO;
using System.Xml.Serialization;

namespace Shopping
{
    class Program
    {
        #region Private

        private Products _products { get; }
        private TaxRates _taxrates { get; }
        private Baskets _baskets { get; }

        private void Cleanup()
        {
            //dispose classes and services here
        }        
        
        #endregion 


        static void Main(string[] args)
        {
            var ProductDeserializer = new ProductDeserializer();
            var TaxRateDeserializer = new TaxRateDeserializer();
            var BasketDeserializer = new BasketDeserializer();

            var _products = ProductDeserializer.DeserializeProducts();
            var _taxRates = TaxRateDeserializer.DeserializeTaxRates();
            var _baskets = BasketDeserializer.DeserializeBaskets();

            var output = new Output();
            output.PrintBaskets(_baskets, _products, _taxRates);

            Console.Out.WriteLine("\nPress a key to close this screen...");
            Console.ReadKey();
        }

    }
}
