using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;

namespace ECommerce_v2.Application.Feature.OrderProcessing.Command.RefundOrder
{
    public class RefundOrderCommand: IRequest
    {
        public Guid OrderId { get; set; }
        public decimal RefundAmount { get; set; }
        public string RefundReason { get; set; } = null!;
    }
}
