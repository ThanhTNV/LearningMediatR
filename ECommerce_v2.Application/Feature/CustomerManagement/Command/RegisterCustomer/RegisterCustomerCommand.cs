using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ECommerce_v2.Application.Common.Model;
using MediatR;

namespace ECommerce_v2.Application.Feature.CustomerManagement.Command.RegisterCustomer
{
    public class RegisterCustomerCommand: IRequest<AuthenticationResult>
    {
        public string Email { get; set; } = null!;
        public string Password { get; set; } = null!; // Will be hashed in handler
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string PhoneNumber { get; set; } = null!;
    }
}
