using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;

namespace ECommerce_v2.Application.Feature.ProductManagement.Command.CreateProduct
{
    public class CreateProductCommand: IRequest
    {
        public string ProductName { get; set; } = null!;
        public string Description { get; set; } = null!;
        public decimal Price { get; set; }
        public decimal Cost { get; set; }
        public string SKU { get; set; } = null!;
        public Guid CategoryId { get; set; }
        public string ImageUrls { get; set; } = null!;
        public string Specifications { get; set; } = null!;
        public double Weight { get; set; }
        public double Length { get; set; }
        public double Width { get; set; }
        public double Height { get; set; }
        public int InventoryCount { get; set; }
        public bool IsActive { get; set; } = true;
    }
}
