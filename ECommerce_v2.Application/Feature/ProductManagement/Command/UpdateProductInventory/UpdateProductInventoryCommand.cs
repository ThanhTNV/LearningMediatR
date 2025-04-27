using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;

namespace ECommerce_v2.Application.Feature.ProductManagement.Command.UpdateProductInventory
{
    public class UpdateProductInventoryCommand: IRequest
    {
        public Guid ProductId { get; set; }
        public int NewInventoryCount { get; set; }
        public string? Reason { get; set; }
    }
}
