using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ECommerce_v2.Application.Common.Dto.OrderProcessing;
using MediatR;

namespace ECommerce_v2.Application.Feature.OrderProcessing.Query.GetOrdersByCustomerId
{
    public class GetOrdersByCustomerId: IRequest<IEnumerable<OrderDetailDto>>
    {
        public Guid CustomerId { get; set; }
    }
}
