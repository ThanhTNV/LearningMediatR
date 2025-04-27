using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ECommerce_v2.Application.Common.Dto.AddressManagement;
using ECommerce_v2.Domain.Enum;
using MediatR;

namespace ECommerce_v2.Application.Feature.AddressManagement.Query.GetAddressesByCustomerId
{
    public class GetAddressesByCustomerIdQuery: IRequest<IEnumerable<AddressDto>>
    {
        public Guid CustomerId { get; set; }
        public AddressType? FilterByType { get; set; }
    }
}
