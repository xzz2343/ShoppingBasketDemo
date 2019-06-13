using Shopping.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopping
{
    public class Output
    {
        #region Private

        private Baskets _baskets { get; set; }
        private Products _products { get; set; }
        private TaxRates _taxrates { get; set; }

        private string _indent = $"      ";

        #endregion

        void Main()
        {

        }

        public void PrintBaskets (Baskets baskets, Products products, TaxRates taxrates)
        {
            _baskets = baskets;
            _products = products;
            _taxrates = taxrates;


            _baskets.Basket.ForEach(delegate (Basket basket)
            {
                PrintBasket(basket);
            });

        }

        private decimal RoundTax(decimal value) {
            return Math.Round(value * 20) / 20;
        }

        private Product FindProduct(int id)
        {
            if (_products.Product.Exists(x => x.ID == id))
            {
                return _products.Product.Find(x => x.ID == id);
            }

            return null;
        }

        public decimal GetImportDuty(decimal price)
        {
            decimal importTaxRate = _taxrates.TaxRate.Find(x => x.ID == 1).Rate;

            return RoundTax(price * importTaxRate);
        }

        public decimal GetProductTax(decimal price)
        {
            decimal baseTaxRate = _taxrates.TaxRate.Find(x => x.ID == 2).Rate;

            return RoundTax(price * baseTaxRate);
        }

        private void PrintBasket(Basket basket)
        {
            decimal basketTax = 0.0M;
            decimal basketTotal = 0.0M;

            Console.WriteLine($"Output {basket.ID}:");

            basket.Item.ForEach(delegate (Item item) {
                Product product = FindProduct(item.ID);
                decimal price = product.Price;
                decimal lineItemPrice = product.Price;
                decimal importDuty = 0.0M;
                decimal itemTax = 0.0M;

                if (product.IsImported)
                {
                    importDuty = GetImportDuty(price);
                }

                lineItemPrice += importDuty;

                if (product.IsTaxable)
                {
                    itemTax = GetProductTax(price);
                }

                lineItemPrice += itemTax;

                basketTax += importDuty + itemTax;

                basketTotal += lineItemPrice;

                Console.WriteLine($"{_indent}{item.Count} {product.Name}: {lineItemPrice:N2}");
            });

            Console.WriteLine($"{_indent}Sales Taxes: {basketTax:N2}");
            Console.WriteLine($"{_indent}Total: {basketTotal:N2}");
        }

    }
}
