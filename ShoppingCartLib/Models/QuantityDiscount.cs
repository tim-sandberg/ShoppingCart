namespace ShoppingCartLib.Models
{
    public class QuantityDiscount
    {
        public string ProductCode { get; set; }
        public int MinimumQuantity { get; set; }
        public decimal DiscountPrice { get; set; }
    }
}
