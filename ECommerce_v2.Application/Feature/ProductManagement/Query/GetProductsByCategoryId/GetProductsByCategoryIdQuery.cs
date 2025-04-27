using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ECommerce_v2.Application.Common.Dto.ProductManagement;
using MediatR;

namespace ECommerce_v2.Application.Feature.ProductManagement.Query.GetProductsByCategoryId
{
    public class GetProductsByCategoryIdQuery: IRequest<IEnumerable<ProductDto>>
    {
        public Guid CategoryId { get; set; }
        public int PageNumber { get; set; } = 1;
        public int PageSize { get; set; } = 20;
        public string? SortBy { get; set; }
        public bool SortDescending { get; set; } = false;
    }
}
