namespace ECommerce_v2.Application.Common.Dto.CustomerManagement
{
    public class CustomerDto
    {
        public Guid CustomerId { get; set; }
        public string Email { get; set; } = null!;
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string PhoneNumber { get; set; } = null!;
        public DateTime CreatedAt { get; set; }
        public int OrderCount { get; set; }
        public DateTime? LastOrderDate { get; set; }
    }
}