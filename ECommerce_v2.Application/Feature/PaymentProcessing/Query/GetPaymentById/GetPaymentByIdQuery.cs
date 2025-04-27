using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ECommerce_v2.Application.Common.Dto.PaymentProcessing;
using MediatR;

namespace ECommerce_v2.Application.Feature.PaymentProcessing.Query.GetPaymentById
{
    public class GetPaymentByIdQuery: IRequest<PaymentDto>
    {
        public Guid PaymentId { get; set; }
    }
}
