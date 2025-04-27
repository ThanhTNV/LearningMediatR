using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;

namespace ECommerce_v2.Application.Feature.ProductReviews.Command.RejectReview
{
    public class RejectReviewCommand: IRequest
    {
        public Guid ReviewId { get; set; }
        public string RejectionReason { get; set; } = null!;
    }
}
