using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ECommerce_v2.Application.Common.Dto.ProductManagement;
using MediatR;

namespace ECommerce_v2.Application.Feature.ProductManagement.Query.GetProductById
{
    public class GetProductByIdQuery: IRequest<ProductDto>
    {
        public Guid ProductId { get; set; }
    }
}
