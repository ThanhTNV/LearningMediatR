namespace ECommerce_v2.Application.Common.Dto.ProductManagement
{
    public class ProductInventoryStatusDto
    {
        public Guid ProductId { get; set; }
        public string ProductName { get; set; } = null!;
        public int InventoryCount { get; set; }
        public bool IsInStock { get; set; }
        public DateTime LastUpdated { get; set; }
    }
}