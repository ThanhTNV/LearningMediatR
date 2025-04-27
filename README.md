# E-Commerce API

A comprehensive e-commerce backend API built with ASP.NET Core, implementing CQRS pattern to provide a clean, scalable architecture.

## Author

**Tran Nguyen Viet Thanh (ThanhSE)**

## Project Overview

This project is a learning-focused implementation of an e-commerce backend API that demonstrates modern C# and ASP.NET Core development practices. The application provides a complete set of API endpoints for managing an online store, including product catalog, customer management, shopping cart functionality, order processing, and more.

## Tech Stack

- **ASP.NET Core Web API** - Framework for building HTTP services
- **Entity Framework Core** - ORM for database operations
- **MediatR** - Implementation of mediator pattern for CQRS
- **AutoMapper** - Object-to-object mapping
- **FluentValidation** - Validation library
- **JWT Authentication** - Secure API endpoints
- **SQL Server** - Database (configurable)

## Features

- **Product Management** - CRUD operations for products and categories
- **Customer Management** - Registration, profile updates, address management
- **Shopping Cart** - Add, update, remove items from cart
- **Order Processing** - Place orders, track status
- **Payment Handling** - Record and update payment status
- **Reviews** - Customer reviews for products

## Architecture

This project follows Clean Architecture principles and implements the CQRS (Command Query Responsibility Segregation) pattern:

### Solution Structure

```
YourECommerceApp/
├── src/
│   ├── YourECommerceApp.API/           # API Controllers and Startup
│   ├── YourECommerceApp.Application/   # Business logic, Commands, Queries, Handlers
│   ├── YourECommerceApp.Domain/        # Domain Entities, Value Objects
│   ├── YourECommerceApp.Infrastructure/# Data Access, External Services
└── tests/
    ├── YourECommerceApp.UnitTests/     # Unit Tests
    └── YourECommerceApp.IntegrationTests/ # Integration Tests
```

### Key Components

1. **Domain Layer**
   - Core business entities
   - Domain logic

2. **Application Layer**
   - Commands and Queries (CQRS)
   - Command/Query Handlers
   - DTOs
   - Validation

3. **Infrastructure Layer**
   - Database context and configurations
   - Repositories implementation
   - Authentication services
   - External service integrations

4. **API Layer**
   - Controllers
   - Middleware configuration
   - API versioning
   - Swagger documentation

## CQRS Implementation

Commands and Queries are separated to optimize for different requirements:

- **Commands** - Handle create, update, delete operations
- **Queries** - Handle data retrieval operations

Example of a command flow:
1. Controller receives request
2. Request is transformed into a command
3. Command is sent via MediatR
4. Command handler validates and processes the command
5. Database is updated
6. Response is returned

## Getting Started

### Prerequisites

- .NET 7.0 SDK or later
- SQL Server (or other compatible database)
- Visual Studio 2022, VS Code, or Rider

### Installation

1. Clone the repository
   ```
   git clone https://github.com/ThanhSE/ecommerce-api.git
   ```

2. Navigate to the project directory
   ```
   cd ecommerce-api
   ```

3. Restore dependencies
   ```
   dotnet restore
   ```

4. Update the database connection string in `appsettings.json`

5. Apply database migrations
   ```
   dotnet ef database update --project src/YourECommerceApp.Infrastructure --startup-project src/YourECommerceApp.API
   ```

6. Run the application
   ```
   dotnet run --project src/YourECommerceApp.API
   ```

### API Documentation

Once the application is running, you can access the Swagger UI to explore the API endpoints:

```
https://localhost:5001/swagger
```

## Development Guidelines

### Creating a New Command/Query

1. **Define the Command/Query class**
   ```csharp
   public class CreateProductCommand : ICommand
   {
       public string ProductName { get; set; } = null!;
       public string Description { get; set; } = null!;
       // Other properties
   }
   ```

2. **Create a validator**
   ```csharp
   public class CreateProductCommandValidator : AbstractValidator<CreateProductCommand>
   {
       public CreateProductCommandValidator()
       {
           RuleFor(x => x.ProductName).NotEmpty().MaximumLength(100);
           RuleFor(x => x.Description).NotEmpty();
           // Other validation rules
       }
   }
   ```

3. **Implement the handler**
   ```csharp
   public class CreateProductCommandHandler : IRequestHandler<CreateProductCommand, Unit>
   {
       private readonly IApplicationDbContext _context;
       private readonly IMapper _mapper;

       public CreateProductCommandHandler(IApplicationDbContext context, IMapper mapper)
       {
           _context = context;
           _mapper = mapper;
       }

       public async Task<Unit> Handle(CreateProductCommand request, CancellationToken cancellationToken)
       {
           var product = _mapper.Map<Product>(request);
           _context.Products.Add(product);
           await _context.SaveChangesAsync(cancellationToken);
           return Unit.Value;
       }
   }
   ```

### Best Practices

1. **Use domain entities only in handlers** - Don't expose them to API controllers
2. **Validate commands and queries** - Use FluentValidation
3. **Keep handlers focused** - Each handler should do one thing well
4. **Use mapping profiles** - Keep mapping logic centralized
5. **Return DTOs from queries** - Never domain entities
6. **Implement proper error handling** - Use custom exception middleware

## Learning Focus

This project was built to practice:

- **C# Language Features** - Records, nullable reference types, pattern matching
- **ASP.NET Core Fundamentals** - Dependency injection, middleware, configuration
- **Entity Framework Core** - Fluent API, migrations, relationships
- **Authentication & Authorization** - JWT implementation, policy-based authorization
- **CQRS Pattern** - Separation of commands and queries
- **Clean Architecture** - Proper separation of concerns

## Future Enhancements

- Implement event sourcing
- Add caching layer for queries
- Set up CI/CD pipeline
- Create admin dashboard
- Add real-time notification system
- Implement product recommendation engine

## License

This project is licensed under the MIT License - see the LICENSE file for details.
