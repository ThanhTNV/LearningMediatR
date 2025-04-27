using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ECommerce_v2.Application.Common.Dto.ProductReviews;
using MediatR;

namespace ECommerce_v2.Application.Feature.ProductReviews.Query.GetPendingReviews
{
    public class GetPendingReviewsQuery: IRequest<IEnumerable<ReviewDto>>
    {
        public int PageNumber { get; set; } = 1;
        public int PageSize { get; set; } = 20;
    }
}
