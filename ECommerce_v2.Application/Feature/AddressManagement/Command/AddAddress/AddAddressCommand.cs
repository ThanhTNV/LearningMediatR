using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ECommerce_v2.Domain.Enum;
using MediatR;

namespace ECommerce_v2.Application.Feature.AddressManagement.Command.AddAddress
{
    public class AddAddressCommand: IRequest<int>
    {
        public Guid CustomerId { get; set; }
        public AddressType AddressType { get; set; }
        public string RecipientFullName { get; set; } = null!;
        public string AddressLine1 { get; set; } = null!;
        public string? AddressLine2 { get; set; }
        public string Ward { get; set; } = null!;
        public string District { get; set; } = null!;
        public string City { get; set; } = null!;
        public string Province { get; set; } = null!;
        public string PhoneNumber { get; set; } = null!;
        public bool IsDefault { get; set; }
    }
}
