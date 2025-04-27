using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;

namespace ECommerce_v2.Application.Feature.ProductManagement.Command.DeactivateProduct
{
    public class DeactivateProductCommand: IRequest
    {
        public Guid ProductId { get; set; }
    }
}
