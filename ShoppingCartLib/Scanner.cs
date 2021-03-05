using ShoppingCartLib.Models;
using System;
using System.Collections.Generic;

namespace ShoppingCartLib
{
    public class Scanner : ITerminal
    {
        private decimal _totalPrice = 0;
        private List<QuantityDiscount> _quantityDiscounts;
        private List<Item> _shoppingCartItems;
        private List<Item> _SKUs;
        private List<ReceiptItem> _receiptItems;

        public Scanner(List<QuantityDiscount> quantityDiscounts, List<Item> skus)
        {
            _quantityDiscounts = quantityDiscounts;
            _SKUs = skus;

            _receiptItems = new List<ReceiptItem>();
            _shoppingCartItems = new List<Item>();
        }

        /// <summary>
        /// item: Name
        /// </summary>
        /// <param name="item"></param>
        public void Scan(string item)
        {
            Item product = GetProduct(item);

            _shoppingCartItems.Add(product);
        }

        public decimal Total()
        {
            CalculateQuantityDiscounts();

            // calculate total price from receipt items
            foreach(ReceiptItem receiptItem in _receiptItems)
            {
                _totalPrice += receiptItem.Amount;
            }

            return _totalPrice;
        }

        private Item GetProduct(string item)
        {
            Item product = _SKUs.Find(prod => prod.Name == item);

            return product;
        }

        private void CalculateQuantityDiscounts()
        {
            // 1. iterate across shopping cart items
            foreach (Item product in _shoppingCartItems)
            {
                // 2. find receipt item, then aggregate quantities, amounts
                ReceiptItem receiptItem = _receiptItems.Find(rcptItem =>
                rcptItem.ProductCode == product.ProductCode);

                if (receiptItem == null)
                {
                    receiptItem = new ReceiptItem();
                    receiptItem.Name = product.Name;
                    receiptItem.ProductCode = product.ProductCode;
                    receiptItem.UnitPrice = product.UnitPrice;

                    _receiptItems.Add(receiptItem);
                }

                // 3. apply quantities, amounts to receipt items
                receiptItem.Amount += product.UnitPrice;
                receiptItem.TotalQuantity += 1;
            }

            // 3. iterate over discounted products
            foreach (QuantityDiscount quantityDiscount in _quantityDiscounts)
            {
                ReceiptItem receiptItem = _receiptItems.Find(receiptItem =>
                receiptItem.ProductCode == quantityDiscount.ProductCode);

                if (receiptItem != null)
                {
                    // 4. apply discounts to receipt item
                    decimal amountAfterDiscount = (int)Math.Floor((double)receiptItem.TotalQuantity
                        / quantityDiscount.MinimumQuantity) * quantityDiscount.DiscountPrice;

                    amountAfterDiscount += (receiptItem.TotalQuantity %
                        quantityDiscount.MinimumQuantity) * receiptItem.UnitPrice;

                    receiptItem.Amount = amountAfterDiscount;
                }
            }
        }
    }
}
