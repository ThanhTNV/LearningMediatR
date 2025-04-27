using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ECommerce_v2.Application.Common.Dto.OrderProcessing;
using ECommerce_v2.Domain.Enum;
using MediatR;

namespace ECommerce_v2.Application.Feature.OrderProcessing.Query.GetCustomerOrdersHistory
{
    public class GetCustomerOrdersHistoryQuery: IRequest<IEnumerable<OrderSummaryDto>>
    {
        public Guid CustomerId { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public OrderStatus? Status { get; set; }
        public int PageNumber { get; set; } = 1;
        public int PageSize { get; set; } = 10;
    }
}
