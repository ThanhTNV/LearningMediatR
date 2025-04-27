using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Metrics;
using System.IO;
using System.Net;
using System.Xml;
using ECommerce_v2.Domain.Enum;

namespace ECommerce_v2.Domain.Entity
{
    public class Address
    {
        public Guid AddressId { get; set; }
        public Guid CustomerId { get; set; }
        public AddressType AddressType { get; set; }
        public string RecipientFullName { get; set; } = null!;
        public string AddressLine1 { get; set; } = null!;
        public string? AddressLine2 { get; set; }
        public string Ward { get; set; } = null!;
        public string District { get; set; } = null!;
        public string City { get; set; } = null!;
        public string Province { get; set; } = null!;
        public bool IsDefault { get; set; } = false;
        [Phone]
        public string PhoneNumber { get; set; } = null!;
        public virtual Customer Customer { get; set; } = null!;
    }
}