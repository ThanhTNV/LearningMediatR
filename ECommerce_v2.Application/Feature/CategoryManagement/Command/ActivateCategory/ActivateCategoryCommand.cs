using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;

namespace ECommerce_v2.Application.Feature.CategoryManagement.Command.ActivateCategory
{
    public class ActivateCategoryCommand: IRequest
    {
        public Guid CategoryId { get; set; }
    }
}
