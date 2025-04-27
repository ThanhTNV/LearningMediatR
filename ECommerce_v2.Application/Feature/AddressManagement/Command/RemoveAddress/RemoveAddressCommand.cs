using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;

namespace ECommerce_v2.Application.Feature.AddressManagement.Command.RemoveAddress
{
    public class RemoveAddressCommand: IRequest<int>
    {
        public Guid AddressId { get; set; }
    }
}
