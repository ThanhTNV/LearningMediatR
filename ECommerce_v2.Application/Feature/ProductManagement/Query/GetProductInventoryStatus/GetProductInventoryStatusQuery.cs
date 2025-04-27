using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ECommerce_v2.Application.Common.Dto.ProductManagement;
using MediatR;

namespace ECommerce_v2.Application.Feature.ProductManagement.Query.GetProductInventoryStatus
{
    public class GetProductInventoryStatusQuery: IRequest<ProductInventoryStatusDto>
    {
        public Guid ProductId { get; set; }
    }
}
