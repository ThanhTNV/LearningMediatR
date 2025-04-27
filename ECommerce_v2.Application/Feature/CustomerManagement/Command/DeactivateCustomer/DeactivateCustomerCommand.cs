using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;

namespace ECommerce_v2.Application.Feature.CustomerManagement.Command.DeactivateCustomer
{
    public class DeactivateCustomerCommand: IRequest
    {
        public Guid CustomerId { get; set; }
        public string? DeactivationReason { get; set; }
    }
}
