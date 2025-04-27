using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ECommerce_v2.Domain.Enum;
using MediatR;

namespace ECommerce_v2.Application.Feature.OrderProcessing.Command.CreateOrder
{
    public class CreateOrderCommand: IRequest
    {
        public Guid CustomerId { get; set; }
        public Guid CartId { get; set; }
        public Guid ShippingAddressId { get; set; }
        public Guid BillingAddressId { get; set; }
        public PaymentMethod PaymentMethod { get; set; }
        public ShippingMethod ShippingMethod { get; set; }
        public string? DiscountCode { get; set; }
        public string? Notes { get; set; }
    }
}
