namespace ECommerce_v2.Application.Common.Dto.CategoryManagement
{
    public class CategoryHierarchyDto
    {
        public Guid CategoryId { get; set; }
        public string CategoryName { get; set; } = null!;
        public bool IsActive { get; set; }
        public int? DisplayOrder { get; set; }
        public ICollection<CategoryHierarchyDto> Subcategories { get; set; } = new List<CategoryHierarchyDto>();
    }
}