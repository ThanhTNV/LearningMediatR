using System.Collections.Generic;
using System.Diagnostics;
using System.Xml;
using ECommerce_v2.Domain.Enum;

namespace ECommerce_v2.Domain.Entity
{
    public class Payment
    {
        public Guid PaymentId { get; set; }
        public Guid OrderId { get; set; }
        public decimal Amount { get; set; }
        public PaymentMethod PaymentMethod { get; set; }
        public string TransactionId { get; set; } = null!;
        public PaymentStatus PaymentStatus { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public virtual Order Order { get; set; } = null!;
    }
}