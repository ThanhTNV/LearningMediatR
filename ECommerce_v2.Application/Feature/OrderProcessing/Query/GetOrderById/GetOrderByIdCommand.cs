using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ECommerce_v2.Application.Common.Dto.OrderProcessing;
using MediatR;

namespace ECommerce_v2.Application.Feature.OrderProcessing.Query.GetOrderById
{
    public class GetOrderByIdCommand: IRequest<OrderDetailDto>
    {
        public Guid OrderId { get; set; }
    }
}
