using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ECommerce_v2.Application.Common.Dto.CustomerManagement;
using MediatR;

namespace ECommerce_v2.Application.Feature.CustomerManagement.Query.GetCustomerByEmail
{
    public class GetCustomerByEmailQuery: IRequest<CustomerDto>
    {
        public string Email { get; set; } = null!;
    }
}
