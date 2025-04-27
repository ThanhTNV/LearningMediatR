using System.Numerics;
using System.Xml;
using ECommerce_v2.Domain.Enum;

namespace ECommerce_v2.Domain.Entity
{
    public class Order
    {
        public Guid OrderId { get; set; }
        public Guid CustomerId { get; set; }
        public DateOnly OrderDate { get; set; }
        public OrderStatus OrderStatus { get; set; }
        public Guid ShippingAddressId { get; set; }
        public Guid BillingAddressId { get; set; }
        public PaymentMethod PaymentMethod { get; set; }
        public ShippingMethod ShippingMethod { get; set; }
        public decimal SubtotalAmount { get; set; }
        public decimal TaxAmount { get; set; }
        public decimal ShippingAmount { get; set; }
        public decimal DiscountAmount { get; set; }
        public decimal TotalAmount { get; set; }
        public string? Notes { get; set; }
        public virtual Address ShippingAddress { get; set; } = null!;
        public virtual Address BillingAddress { get; set; } = null!;
        public virtual Customer Customer { get; set; } = null!;
        public virtual ICollection<OrderItem> OrderItems { get; set; } = null!;
        public virtual ICollection<Payment> PaymentRecords { get; set; } = null!;
    }
}