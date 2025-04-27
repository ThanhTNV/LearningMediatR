using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ECommerce_v2.Application.Common.Dto.ShoppingCart;
using MediatR;

namespace ECommerce_v2.Application.Feature.ShoppingCart.Query.GetCartItems
{
    public class GetCartItemsQuery: IRequest<IEnumerable<CartItemDto>>
    {
        public Guid CartId { get; set; }
    }
}
