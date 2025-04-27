using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ECommerce_v2.Application.Common.Dto.AddressManagement;
using MediatR;

namespace ECommerce_v2.Application.Feature.CustomerManagement.Query.GetCustomerAddresses
{
    public class GetCustomerAddressesQuery: IRequest<IEnumerable<AddressDto>>
    {
        public Guid CustomerId { get; set; }
    }
}
