namespace ECommerce_v2.Application.Common.Dto.ProductManagement
{
    public class ProductDto
    {
        public Guid ProductId { get; set; }
        public string ProductName { get; set; } = null!;
        public string Description { get; set; } = null!;
        public decimal Price { get; set; }
        public string SKU { get; set; } = null!;
        public string CategoryName { get; set; } = null!;
        public Guid CategoryId { get; set; }
        public string ImageUrls { get; set; } = null!;
        public string Specifications { get; set; } = null!;
        public int InventoryCount { get; set; }
        public bool IsInStock { get; set; }
        public bool IsActive { get; set; }
    }
}