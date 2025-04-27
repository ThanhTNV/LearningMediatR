using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;

namespace ECommerce_v2.Application.Feature.ShoppingCart.Command.CreateCart
{
    public class CreateCartCommand: IRequest
    {
        public Guid CustomerId { get; set; }
    }
}
