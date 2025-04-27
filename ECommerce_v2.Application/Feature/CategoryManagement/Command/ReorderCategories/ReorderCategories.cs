using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;

namespace ECommerce_v2.Application.Feature.CategoryManagement.Command.ReorderCategories
{
    public class ReorderCategories: IRequest
    {
        public Dictionary<Guid, int> CategoryOrders { get; set; } = null!;
    }
}
