using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ECommerce_v2.Domain.Enum;
using MediatR;

namespace ECommerce_v2.Application.Feature.AddressManagement.Command.UpdateAddress
{
    public class UpdateAddressCommand: IRequest
    {
        public Guid AddressId { get; set; }
        public AddressType? AddressType { get; set; }
        public string? RecipientFullName { get; set; }
        public string? AddressLine1 { get; set; }
        public string? AddressLine2 { get; set; }
        public string? Ward { get; set; }
        public string? District { get; set; }
        public string? City { get; set; }
        public string? Province { get; set; }
        public string? PhoneNumber { get; set; }
    }
}
