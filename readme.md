# Inventory API

A RESTful API for managing product inventory built with ASP.NET Core.

## Description

This API provides endpoints to manage products in an inventory system, allowing for basic CRUD operations (Create, Read, Update, Delete).

## Endpoints

### Get All Products
```http
GET /products
```
Returns a list of all products in the inventory.

### Get Product by ID
```http
GET /products/{id}
```
Returns a specific product by its ID.

### Create Product
```http
POST /products
```
Creates a new product in the inventory.

**Request Body:**
```json
{
    "name": "string",
    "price": decimal,
    "quantity": int
}
```

### Update Product
```http
PUT /products/{id}
```
Updates an existing product.

**Request Body:**
```json
{
    "name": "string",
    "price": decimal,
    "quantity": int
}
```

### Delete Product
```http
DELETE /products/{id}
```
Deletes a product from the inventory.

## Technologies Used

- ASP.NET Core 8
- Entity Framework Core
- SQLite Database
- GitHub Actions for CI/CD
- Azure Web Apps for hosting

## Getting Started

1. Clone the repository
2. Install .NET 8 SDK
3. Run the following commands:

```bash
dotnet restore
dotnet build
dotnet run --project InventoryApi
```

## Testing

Run the tests using:

```bash
dotnet test
```