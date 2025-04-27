using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;

namespace ECommerce_v2.Application.Feature.ShoppingCart.Command.ClearCart
{
    public class ClearCartCommand: IRequest
    {
        public Guid CartId { get; set; }
    }
}
