using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ECommerce_v2.Domain.Enum;
using MediatR;

namespace ECommerce_v2.Application.Feature.PaymentProcessing.Command.UpdatePaymentStatus
{
    public class UpdatePaymentStatusCommand: IRequest
    {
        public Guid PaymentId { get; set; }
        public PaymentStatus NewStatus { get; set; }
        public string? StatusNote { get; set; }
    }
}
