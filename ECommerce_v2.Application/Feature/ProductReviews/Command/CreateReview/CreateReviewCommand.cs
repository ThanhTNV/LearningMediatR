using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;

namespace ECommerce_v2.Application.Feature.ProductReviews.Command.CreateReview
{
    public class CreateReviewCommand: IRequest
    {
        public Guid ProductId { get; set; }
        public Guid CustomerId { get; set; }
        public int Rating { get; set; }
        public string Title { get; set; } = null!;
        public string Content { get; set; } = null!;
    }
}
