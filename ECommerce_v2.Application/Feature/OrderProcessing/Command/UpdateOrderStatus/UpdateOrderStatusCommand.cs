using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ECommerce_v2.Domain.Enum;
using MediatR;

namespace ECommerce_v2.Application.Feature.OrderProcessing.Command.UpdateOrderStatus
{
    public class UpdateOrderStatusCommand: IRequest
    {
        public Guid OrderId { get; set; }
        public OrderStatus NewStatus { get; set; }
        public string? StatusNote { get; set; }
    }
}
