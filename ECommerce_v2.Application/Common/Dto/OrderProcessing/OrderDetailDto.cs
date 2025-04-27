using ECommerce_v2.Application.Common.Dto.AddressManagement;
using ECommerce_v2.Application.Common.Dto.PaymentProcessing;
using ECommerce_v2.Domain.Enum;

namespace ECommerce_v2.Application.Common.Dto.OrderProcessing
{
    public class OrderDetailDto
    {
        public Guid OrderId { get; set; }
        public Guid CustomerId { get; set; }
        public string CustomerName { get; set; } = null!;
        public DateTime OrderDate { get; set; }
        public OrderStatus OrderStatus { get; set; }
        public AddressDto ShippingAddress { get; set; } = null!;
        public AddressDto BillingAddress { get; set; } = null!;
        public PaymentMethod PaymentMethod { get; set; }
        public ShippingMethod ShippingMethod { get; set; }
        public decimal SubtotalAmount { get; set; }
        public decimal TaxAmount { get; set; }
        public decimal ShippingAmount { get; set; }
        public decimal DiscountAmount { get; set; }
        public decimal TotalAmount { get; set; }
        public string? Notes { get; set; }
        public ICollection<OrderItemDto> OrderItems { get; set; } = new List<OrderItemDto>();
        public ICollection<PaymentDto> Payments { get; set; } = new List<PaymentDto>();
    }
}