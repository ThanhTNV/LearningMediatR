using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;

namespace ECommerce_v2.Application.Feature.ProductReviews.Command.ApproveReview
{
    public class ApproveReviewCommand: IRequest
    {
        public Guid ReviewId { get; set; }
        public string? ApproverNote { get; set; }
    }
}
