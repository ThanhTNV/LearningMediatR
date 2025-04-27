using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using ECommerce_v2.Application.Common.Dto.AddressManagement;
using ECommerce_v2.Application.Common.Dto.CategoryManagement;
using ECommerce_v2.Application.Common.Dto.CustomerManagement;
using ECommerce_v2.Application.Common.Dto.OrderProcessing;
using ECommerce_v2.Application.Common.Dto.PaymentProcessing;
using ECommerce_v2.Application.Common.Dto.ProductManagement;
using ECommerce_v2.Application.Common.Dto.ProductReviews;
using ECommerce_v2.Application.Common.Dto.ShoppingCart;
using ECommerce_v2.Application.Feature.AddressManagement.Command.AddAddress;
using ECommerce_v2.Application.Feature.AddressManagement.Command.UpdateAddress;
using ECommerce_v2.Application.Feature.OrderProcessing.Command.CreateOrder;
using ECommerce_v2.Application.Feature.PaymentProcessing.Command.CreatePayment;
using ECommerce_v2.Application.Feature.ProductReviews.Command.CreateReview;
using ECommerce_v2.Domain.Entity;
using ECommerce_v2.Domain.Enum;

namespace ECommerce_v2.Application.Mapping
{
    public class ECommerceMappingProfile : Profile
    {
        public ECommerceMappingProfile()
        {
            // Product Mappings
            CreateMap<Product, ProductDto>()
                .ForMember(dest => dest.CategoryName, opt => opt.MapFrom(src => src.Category.CategoryName))
                .ForMember(dest => dest.IsInStock, opt => opt.MapFrom(src => src.InventoryCount > 0));

            CreateMap<Product, ProductInventoryStatusDto>()
                .ForMember(dest => dest.IsInStock, opt => opt.MapFrom(src => src.InventoryCount > 0))
                .ForMember(dest => dest.LastUpdated, opt => opt.MapFrom(src => src.UpdatedAt));

            // Category Mappings
            CreateMap<Category, CategoryDto>()
                .ForMember(dest => dest.ParentCategoryName, opt => opt.MapFrom(src =>
                    src.ParentCategory != null ? src.ParentCategory.CategoryName : null))
                .ForMember(dest => dest.ProductCount, opt => opt.MapFrom(src =>
                    src.Products != null ? src.Products.Count : 0));

            CreateMap<Category, CategoryHierarchyDto>()
                .ForMember(dest => dest.Subcategories, opt => opt.Ignore()); // Handle this manually in handler

            // Customer Mappings
            CreateMap<Customer, CustomerDto>()
                .ForMember(dest => dest.OrderCount, opt => opt.MapFrom(src =>
                    src.Orders != null ? src.Orders.Count : 0))
                .ForMember(dest => dest.LastOrderDate, opt => opt.MapFrom(src =>
                    src.Orders != null && src.Orders.Any() ? 
                    src.Orders.Max(o => o.OrderDate) : (DateOnly?)null));

            // Address Mappings
            CreateMap<Address, AddressDto>();
            CreateMap<AddAddressCommand, Address>()
                .ForMember(dest => dest.AddressId, opt => opt.MapFrom(src => Guid.NewGuid()));
            CreateMap<UpdateAddressCommand, Address>()
                .ForAllMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null));

            // Cart Mappings
            CreateMap<Cart, CartDto>()
                .ForMember(dest => dest.Subtotal, opt => opt.MapFrom(src =>
                    src.CartItems != null ? src.CartItems.Sum(ci => ci.Quantity * ci.Product.Price) : 0))
                .ForMember(dest => dest.EstimatedTax, opt => opt.Ignore()) // Calculate in handler
                .ForMember(dest => dest.EstimatedShipping, opt => opt.Ignore()) // Calculate in handler
                .ForMember(dest => dest.DiscountAmount, opt => opt.Ignore()) // Calculate in handler
                .ForMember(dest => dest.Total, opt => opt.Ignore()); // Calculate in handler

            CreateMap<Cart, CartSummaryDto>()
                .ForMember(dest => dest.ItemCount, opt => opt.MapFrom(src =>
                    src.CartItems != null ? src.CartItems.Sum(ci => ci.Quantity) : 0))
                .ForMember(dest => dest.Subtotal, opt => opt.MapFrom(src =>
                    src.CartItems != null ? src.CartItems.Sum(ci => ci.Quantity * ci.Product.Price) : 0))
                .ForMember(dest => dest.EstimatedTotal, opt => opt.Ignore()); // Calculate in handler

            CreateMap<CartItem, CartItemDto>()
                .ForMember(dest => dest.ProductName, opt => opt.MapFrom(src => src.Product.ProductName))
                .ForMember(dest => dest.ImageUrl, opt => opt.MapFrom(src => src.Product.ImageUrls))
                .ForMember(dest => dest.ProductPrice, opt => opt.MapFrom(src => src.Product.Price))
                .ForMember(dest => dest.Subtotal, opt => opt.MapFrom(src => src.Quantity * src.Product.Price));

            // Order Mappings
            CreateMap<Order, OrderSummaryDto>()
                .ForMember(dest => dest.ItemCount, opt => opt.MapFrom(src =>
                    src.OrderItems != null ? src.OrderItems.Sum(oi => oi.Quantity) : 0))
                .ForMember(dest => dest.ShippingAddress, opt => opt.MapFrom(src =>
                    $"{src.ShippingAddress.RecipientFullName}, {src.ShippingAddress.AddressLine1}, {src.ShippingAddress.City}"))
                .ForMember(dest => dest.PaymentStatus, opt => opt.MapFrom(src =>
                    src.PaymentRecords != null && src.PaymentRecords.Any() ?
                    src.PaymentRecords.OrderByDescending(p => p.CreatedAt).First().PaymentStatus : PaymentStatus.Pending));

            CreateMap<Order, OrderDetailDto>()
                .ForMember(dest => dest.CustomerName, opt => opt.MapFrom(src =>
                    $"{src.Customer.FirstName} {src.Customer.LastName}"));

            CreateMap<OrderItem, OrderItemDto>()
                .ForMember(dest => dest.Subtotal, opt => opt.MapFrom(src => src.Quantity * src.ProductPrice));

            CreateMap<CreateOrderCommand, Order>()
                .ForMember(dest => dest.OrderId, opt => opt.MapFrom(src => Guid.NewGuid()))
                .ForMember(dest => dest.OrderDate, opt => opt.MapFrom(src => DateOnly.FromDateTime(DateTime.UtcNow)))
                .ForMember(dest => dest.OrderStatus, opt => opt.MapFrom(src => OrderStatus.Pending))
                .ForMember(dest => dest.OrderItems, opt => opt.Ignore()) // Set in handler from cart items
                .ForMember(dest => dest.SubtotalAmount, opt => opt.Ignore()) // Calculate in handler
                .ForMember(dest => dest.TaxAmount, opt => opt.Ignore()) // Calculate in handler
                .ForMember(dest => dest.ShippingAmount, opt => opt.Ignore()) // Calculate in handler
                .ForMember(dest => dest.DiscountAmount, opt => opt.Ignore()) // Calculate in handler
                .ForMember(dest => dest.TotalAmount, opt => opt.Ignore()); // Calculate in handler

            // Payment Mappings
            CreateMap<Payment, PaymentDto>();
            CreateMap<CreatePaymentCommand, Payment>()
                .ForMember(dest => dest.PaymentId, opt => opt.MapFrom(src => Guid.NewGuid()))
                .ForMember(dest => dest.PaymentStatus, opt => opt.MapFrom(src => PaymentStatus.Pending))
                .ForMember(dest => dest.CreatedAt, opt => opt.MapFrom(src => DateTime.UtcNow))
                .ForMember(dest => dest.UpdatedAt, opt => opt.MapFrom(src => DateTime.UtcNow));

            // Review Mappings
            CreateMap<Review, ReviewDto>()
                .ForMember(dest => dest.ProductName, opt => opt.MapFrom(src => src.Product.ProductName))
                .ForMember(dest => dest.CustomerName, opt => opt.MapFrom(src =>
                    $"{src.Customer.FirstName} {src.Customer.LastName}"));

            CreateMap<CreateReviewCommand, Review>()
                .ForMember(dest => dest.ReviewId, opt => opt.MapFrom(src => Guid.NewGuid()))
                .ForMember(dest => dest.CreatedAt, opt => opt.MapFrom(src => DateTime.UtcNow))
                .ForMember(dest => dest.ReviewStatus, opt => opt.MapFrom(src => ReviewStatus.Pending))
                .ForMember(dest => dest.HelpfulVotes, opt => opt.MapFrom(src => 0));
        }
    }
}
