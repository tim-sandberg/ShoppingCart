namespace ShoppingCartLib.Models
{
    public class ReceiptItem : Item
    {
        public decimal Amount { get; set; }
        public int TotalQuantity { get; set; }
    }
}
