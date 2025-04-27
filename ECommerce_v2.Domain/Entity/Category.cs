using System.Xml;

namespace ECommerce_v2.Domain.Entity
{
    public class Category
    {
        public Guid CategoryId { get; set; }
        public string CategoryName { get; set; } = null!;
        public string Description { get; set; } = null!;
        public Guid ParentCategoryId { get; set; }
        public string? ImageUrl { get; set; }
        public bool IsActive { get; set; }
        public int? DisplayOrder { get; set; }
        public virtual Category ParentCategory { get; set; } = null!;
        public virtual ICollection<Product> Products { get; set; } = null!;
    }
}