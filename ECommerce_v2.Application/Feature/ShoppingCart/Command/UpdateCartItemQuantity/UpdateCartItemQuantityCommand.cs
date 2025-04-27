using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;

namespace ECommerce_v2.Application.Feature.ShoppingCart.Command.UpdateCartItemQuantity
{
    public class UpdateCartItemQuantityCommand: IRequest
    {
        public Guid CartId { get; set; }
        public Guid CartItemId { get; set; }
        public int NewQuantity { get; set; }
    }
}
