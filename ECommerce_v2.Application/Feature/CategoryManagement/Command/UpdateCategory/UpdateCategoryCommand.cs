using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;

namespace ECommerce_v2.Application.Feature.CategoryManagement.Command.UpdateCategory
{
    public class UpdateCategoryCommand: IRequest
    {
        public Guid CategoryId { get; set; }
        public string? CategoryName { get; set; }
        public string? Description { get; set; }
        public Guid? ParentCategoryId { get; set; }
        public string? ImageUrl { get; set; }
        public int? DisplayOrder { get; set; }
    }
}
