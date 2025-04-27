namespace ECommerce_v2.Application.Common.Dto.ShoppingCart
{
    public class CartSummaryDto
    {
        public Guid CartId { get; set; }
        public int ItemCount { get; set; }
        public decimal Subtotal { get; set; }
        public decimal EstimatedTotal { get; set; }
    }
}