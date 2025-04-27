using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;

namespace ECommerce_v2.Application.Feature.CategoryManagement.Command.CreateCategory
{
    public class CreateCategoryCommand: IRequest
    {
        public string CategoryName { get; set; } = null!;
        public string Description { get; set; } = null!;
        public Guid? ParentCategoryId { get; set; }
        public string? ImageUrl { get; set; }
        public bool IsActive { get; set; } = true;
        public int? DisplayOrder { get; set; }
    }
}
