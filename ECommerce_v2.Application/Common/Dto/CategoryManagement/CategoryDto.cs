namespace ECommerce_v2.Application.Common.Dto.CategoryManagement
{
    public class CategoryDto
    {
        public Guid CategoryId { get; set; }
        public string CategoryName { get; set; } = null!;
        public string Description { get; set; } = null!;
        public Guid? ParentCategoryId { get; set; }
        public string? ParentCategoryName { get; set; }
        public string? ImageUrl { get; set; }
        public bool IsActive { get; set; }
        public int? DisplayOrder { get; set; }
        public int ProductCount { get; set; }
    }
}