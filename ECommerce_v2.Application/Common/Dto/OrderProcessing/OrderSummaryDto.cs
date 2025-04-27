using ECommerce_v2.Domain.Enum;

namespace ECommerce_v2.Application.Common.Dto.OrderProcessing
{
    public class OrderSummaryDto
    {
        public Guid OrderId { get; set; }
        public DateTime OrderDate { get; set; }
        public OrderStatus OrderStatus { get; set; }
        public int ItemCount { get; set; }
        public decimal TotalAmount { get; set; }
        public string ShippingAddress { get; set; } = null!;
        public PaymentStatus PaymentStatus { get; set; }
    }
}