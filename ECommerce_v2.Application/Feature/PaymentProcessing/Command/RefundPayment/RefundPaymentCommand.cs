using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;

namespace ECommerce_v2.Application.Feature.PaymentProcessing.Command.RefundPayment
{
    public class RefundPaymentCommand: IRequest
    {
        public Guid PaymentId { get; set; }
        public decimal RefundAmount { get; set; }
        public string RefundReason { get; set; } = null!;
    }
}
