using System.Collections.Generic;
using System.Xml;

namespace ECommerce_v2.Domain.Entity
{
    public class Cart
    {
        public Guid CartId { get; set; }
        public Guid CustomerId { get; set; }
        public DateOnly CreatedAt {get;set;}
        public DateOnly UpdatedAt { get;set;}
        public DateOnly ExpiresAt { get;set;}
        public virtual Customer Customer { get; set; } = null!;
        public virtual ICollection<CartItem> CartItems { get; set; } = null!;
    }
}