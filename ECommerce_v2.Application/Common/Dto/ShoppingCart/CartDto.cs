namespace ECommerce_v2.Application.Common.Dto.ShoppingCart
{
    public class CartDto
    {
        public Guid CartId { get; set; }
        public Guid? CustomerId { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public DateTime ExpiresAt { get; set; }
        public ICollection<CartItemDto> Items { get; set; } = new List<CartItemDto>();
        public decimal Subtotal { get; set; }
        public decimal EstimatedTax { get; set; }
        public decimal EstimatedShipping { get; set; }
        public string? AppliedDiscountCode { get; set; }
        public decimal DiscountAmount { get; set; }
        public decimal Total { get; set; }
    }
}