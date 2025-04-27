using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Xml;
using ECommerce_v2.Domain.Enum;

namespace ECommerce_v2.Domain.Entity
{
    public class Review
    {
        public Guid ReviewId { get; set; }
        public Guid ProductId { get; set; }
        public Guid CustomerId { get; set; }
        public int Rating { get; set; }
        public string Title { get; set; } = null!;
        public string Content { get; set; } = null!;
        public DateTime CreatedAt { get; set; }
        public ReviewStatus ReviewStatus { get; set; }
        public int HelpfulVotes { get; set; }
        public virtual Product Product { get; set; } = null!;
        public virtual Customer Customer { get; set; } = null!;
    }
}