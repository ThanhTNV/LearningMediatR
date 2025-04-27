using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;

namespace ECommerce_v2.Application.Feature.CustomerManagement.Command.UpdateCustomerProfile
{
    class UpdateCustomerProfileCommand: IRequest
    {
        public Guid CustomerId { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? PhoneNumber { get; set; }
    }
}
