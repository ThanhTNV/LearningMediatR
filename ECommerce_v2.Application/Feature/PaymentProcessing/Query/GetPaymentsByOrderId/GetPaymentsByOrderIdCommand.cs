using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ECommerce_v2.Application.Common.Dto.PaymentProcessing;
using MediatR;

namespace ECommerce_v2.Application.Feature.PaymentProcessing.Query.GetPaymentsByOrderId
{
    public class GetPaymentsByOrderIdCommand: IRequest<IEnumerable<PaymentDto>>
    {
        public Guid PaymentId { get; set; }
    }
}
