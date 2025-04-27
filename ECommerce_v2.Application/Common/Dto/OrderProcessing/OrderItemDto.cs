using ECommerce_v2.Domain.Enum;

namespace ECommerce_v2.Application.Common.Dto.OrderProcessing
{
    public class OrderItemDto
    {
        public Guid OrderItemId { get; set; }
        public Guid OrderId { get; set; }
        public Guid ProductId { get; set; }
        public string ProductName { get; set; } = null!;
        public decimal ProductPrice { get; set; }
        public int Quantity { get; set; }
        public decimal Subtotal { get; set; }
        public OrderItemStatus OrderItemStatus { get; set; }
    }
}