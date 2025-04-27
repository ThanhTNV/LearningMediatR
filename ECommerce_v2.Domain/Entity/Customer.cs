using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ECommerce_v2.Domain.Entity
{
    public class Customer
    {
        public Guid CustomerId { get; set; }
        public string Email { get; set; } = null!;
        public string HashedPassword { get; set; } = null!;
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        [Phone]
        public string PhoneNumber { get; set; } = null!;
        public DateTime CreatedAt { get; set; }
        public Guid CartId { get; set; }
        public virtual Cart? Cart { get; set; }
        public virtual ICollection<Address> Addresses { get; set; } = null!;
        public virtual ICollection<Order> Orders { get; set; } = null!;
        public virtual ICollection<Review> Reviews { get; set; } = null!;
    }
}
