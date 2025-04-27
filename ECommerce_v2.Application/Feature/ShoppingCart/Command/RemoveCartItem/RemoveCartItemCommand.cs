using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;

namespace ECommerce_v2.Application.Feature.ShoppingCart.Command.RemoveCartItem
{
    public class RemoveCartItemCommand: IRequest
    {
        public Guid CartId { get; set; }
        public Guid CartItemId { get; set; }
    }
}
