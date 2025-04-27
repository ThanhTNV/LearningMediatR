using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ECommerce_v2.Application.Common.Dto.CategoryManagement;
using MediatR;

namespace ECommerce_v2.Application.Feature.CategoryManagement.Query.GetCategoryHierarchy
{
    public class GetCategoryHierarchyQuery: IRequest<IEnumerable<CategoryHierarchyDto>>
    {
        public bool? IncludeInactive { get; set; }
    }
}
