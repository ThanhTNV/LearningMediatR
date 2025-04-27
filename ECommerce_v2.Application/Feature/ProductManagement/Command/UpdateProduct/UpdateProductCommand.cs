using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;

namespace ECommerce_v2.Application.Feature.ProductManagement.Command.UpdateProduct
{
    public class UpdateProductCommand: IRequest
    {
        public Guid ProductId { get; set; }
        public string? ProductName { get; set; }
        public string? Description { get; set; }
        public decimal? Price { get; set; }
        public decimal? Cost { get; set; }
        public string? SKU { get; set; }
        public Guid? CategoryId { get; set; }
        public string? ImageUrls { get; set; }
        public string? Specifications { get; set; }
        public double? Weight { get; set; }
        public double? Length { get; set; }
        public double? Width { get; set; }
        public double? Height { get; set; }
    }
}
