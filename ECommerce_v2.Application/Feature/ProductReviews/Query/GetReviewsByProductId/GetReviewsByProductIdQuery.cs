using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ECommerce_v2.Application.Common.Dto.ProductReviews;
using ECommerce_v2.Domain.Enum;
using MediatR;

namespace ECommerce_v2.Application.Feature.ProductReviews.Query.GetReviewsByProductId
{
    public class GetReviewsByProductIdQuery: IRequest<IEnumerable<ReviewDto>>
    {
        public Guid ProductId { get; set; }
        public ReviewStatus? Status { get; set; }
        public int PageNumber { get; set; } = 1;
        public int PageSize { get; set; } = 10;
        public string? SortBy { get; set; }
        public bool SortDescending { get; set; } = false;
    }
}
