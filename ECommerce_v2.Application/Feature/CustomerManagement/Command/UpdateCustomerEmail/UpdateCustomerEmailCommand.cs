using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;

namespace ECommerce_v2.Application.Feature.CustomerManagement.Command.UpdateCustomerEmail
{
    public class UpdateCustomerEmailCommand: IRequest
    {
        public Guid CustomerId { get; set; }
        public string OldEmail { get; set; } = null!;
        public string NewEmail { get; set; } = null!;
    }
}
