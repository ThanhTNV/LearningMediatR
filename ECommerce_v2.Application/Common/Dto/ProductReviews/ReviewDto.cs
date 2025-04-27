using ECommerce_v2.Domain.Enum;

namespace ECommerce_v2.Application.Common.Dto.ProductReviews
{
    public class ReviewDto
    {
        public Guid ReviewId { get; set; }
        public Guid ProductId { get; set; }
        public string ProductName { get; set; } = null!;
        public Guid CustomerId { get; set; }
        public string CustomerName { get; set; } = null!;
        public int Rating { get; set; }
        public string Title { get; set; } = null!;
        public string Content { get; set; } = null!;
        public DateTime CreatedAt { get; set; }
        public ReviewStatus ReviewStatus { get; set; }
        public int HelpfulVotes { get; set; }
    }
}