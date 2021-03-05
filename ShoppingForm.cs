using ShoppingCartLib;
using ShoppingCartLib.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace ShoppingCart
{
    public partial class ShoppingForm : Form
    {
        private Scanner _scanner;
        private List<Item> _shoppingCart;
        private List<Item> _skus;
        private decimal _totalPrice;

        public ShoppingForm()
        {
            InitializeComponent();

            Initialize();
        }

        private void Initialize()
        {
            _shoppingCart = new List<Item>();
            List<QuantityDiscount> quantityDiscounts = GetQuantityDiscounts();
            _skus = GetSKUs();

            _scanner = new Scanner(quantityDiscounts, _skus);
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

        private void BtnApples_OnClick(object sender, EventArgs e)
        {
            Item apple = _skus.Find(sku => sku.Name == "Apple");

            _shoppingCart.Add(apple);

            UpdateCartLabel();
        }

        private void UpdateCartLabel()
        {
            StringBuilder shoppingCartLabel = new StringBuilder();

            foreach (Item shoppingCartItem in _shoppingCart)
            {
                shoppingCartLabel.Append("\n" + shoppingCartItem.Name);
            }

            lblShoppingCart.Text = shoppingCartLabel.ToString();
        }

        private void BtnBroccoli_OnClick(object sender, EventArgs e)
        {
            Item broccoli = _skus.Find(sku => sku.Name == "Broccoli");

            _shoppingCart.Add(broccoli);
        }

        private void BtnCarrots_OnClick(object sender, EventArgs e)
        {
            Item carrots = _skus.Find(sku => sku.Name == "Carrots");

            _shoppingCart.Add(carrots);
        }

        private void BtnDillPickles_OnClick(object sender, EventArgs e)
        {
            Item dillPickles = _skus.Find(sku => sku.Name == "DillPickles");

            _shoppingCart.Add(dillPickles);
        }

        private void BtnScan_OnClick(object sender, EventArgs e)
        {
            foreach (Item shoppingCartItem in _shoppingCart)
            {
                _scanner.Scan(shoppingCartItem.Name);
            }

            _totalPrice = _scanner.Total();

            lblTotal.Text = $"Your total payment amounts to {_totalPrice:C}";
        }

        private void ShoppingForm_Load(object sender, EventArgs e)
        {

        }

        private void btnClearCart_Click(object sender, EventArgs e)
        {
            _shoppingCart.Clear();
            
            lblShoppingCart.Text = "";

            _totalPrice = 0;

            lblTotal.Text= "$0.00";

        }
    }
}
