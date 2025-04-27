using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ECommerce_v2.Domain.Enum;
using MediatR;

namespace ECommerce_v2.Application.Feature.AddressManagement.Command.SetDefaultAddress
{
    public class SetDefaultAddressCommand: IRequest
    {
        public Guid CustomerId { get; set; }
        public Guid AddressId { get; set; }
        public AddressType AddressType { get; set; }
    }
}
