using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShoppingCartLib;
using ShoppingCartLib.Models;
using System.Collections.Generic;

namespace ShoppingCartUnitTest
{
    [TestClass]
    public class ScanItemsTest
    {
        private List<QuantityDiscount> _quantityDiscounts;
        private List<Item> _skus;

        public ScanItemsTest()
        {
            _quantityDiscounts = GetQuantityDiscounts();
            _skus = GetSKUs();
        }

        /// <summary>
        /// ABCDABAA; Verify the total price is $32.40
        /// </summary>
        [TestMethod]
        public void ScanScenario1()
        {
            Scanner scanner = new Scanner(_quantityDiscounts, _skus);

            scanner.Scan("Apple");
            scanner.Scan("Broccoli");
            scanner.Scan("Carrots");
            scanner.Scan("DillPickles");
            scanner.Scan("Apple");
            scanner.Scan("Broccoli");
            scanner.Scan("Apple");
            scanner.Scan("Apple");

            decimal totalPrice = scanner.Total();

            Assert.AreEqual((decimal)32.40, totalPrice);
        }

        /// <summary>
        /// CCCCCCC; Verify the total price is $7.25
        /// </summary>
        [TestMethod]
        public void ScanScenario2()
        {
            Scanner scanner = new Scanner(_quantityDiscounts, _skus);

            scanner.Scan("Carrots");
            scanner.Scan("Carrots");
            scanner.Scan("Carrots");
            scanner.Scan("Carrots");
            scanner.Scan("Carrots");
            scanner.Scan("Carrots");
            scanner.Scan("Carrots");

            decimal totalPrice = scanner.Total();

            Assert.AreEqual((decimal)7.25, totalPrice);
        }

        /// <summary>
        /// ABCD; Verify the total price is $15.40
        /// </summary>
        [TestMethod]
        public void ScanScenario3()
        {
            Scanner scanner = new Scanner(_quantityDiscounts, _skus);

            scanner.Scan("Apple");
            scanner.Scan("Broccoli");
            scanner.Scan("Carrots");
            scanner.Scan("DillPickles");

            decimal totalPrice = scanner.Total();

            Assert.AreEqual((decimal)15.40, totalPrice);
        }

        private List<QuantityDiscount> GetQuantityDiscounts()
        {
            List<QuantityDiscount> quantityDiscounts = new List<QuantityDiscount>();

            QuantityDiscount quantityDiscountA = new QuantityDiscount();
            quantityDiscountA.DiscountPrice = 7;
            quantityDiscountA.MinimumQuantity = 4;
            quantityDiscountA.ProductCode = "A";

            quantityDiscounts.Add(quantityDiscountA);

            QuantityDiscount quantityDiscountC = new QuantityDiscount();
            quantityDiscountC.DiscountPrice = 6;
            quantityDiscountC.MinimumQuantity = 6;
            quantityDiscountC.ProductCode = "C";

            quantityDiscounts.Add(quantityDiscountC);

            return quantityDiscounts;
        }

        private List<Item> GetSKUs()
        {
            List<Item> skus = new List<Item>();

            Item apple = new Item();
            apple.Name = "Apple";
            apple.ProductCode = "A";
            apple.UnitPrice = 2;

            skus.Add(apple);

            Item broccoli = new Item();
            broccoli.Name = "Broccoli";
            broccoli.ProductCode = "B";
            broccoli.UnitPrice = 12;

            skus.Add(broccoli);

            Item carrots = new Item();
            carrots.Name = "Carrots";
            carrots.ProductCode = "C";
            carrots.UnitPrice = (decimal)1.25;

            skus.Add(carrots);

            Item dillPickles = new Item();
            dillPickles.Name = "DillPickles";
            dillPickles.ProductCode = "D";
            dillPickles.UnitPrice = (decimal).15;

            skus.Add(dillPickles);
            
            return skus;
        }
    }
}
