using ECommerce_v2.Domain.Enum;

namespace ECommerce_v2.Application.Common.Dto.AddressManagement
{
    public class AddressDto
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
        public bool IsDefault { get; set; }
        public string PhoneNumber { get; set; } = null!;
    }
}