using InventoryApi.Data;
using InventoryApi.Dtos;
using InventoryApi.Entities;
using InventoryApi.Mapping;
using Microsoft.EntityFrameworkCore;

namespace InventoryApi.Endpoints;

public static class ProductsEndpoints
{
    const string ProductsEndpointName = "";

    public static RouteGroupBuilder MapProductEndpoints(this WebApplication app)
    {
        RouteGroupBuilder group = app.MapGroup("products");

        //GET ALL
        group.MapGet("/", (InventoryContext dbContext) => dbContext.Products.Select(product => product.ToDto()));

        //GET by ID
        group.MapGet("/{id}", (int id, InventoryContext dbContext) =>
        {
            Product? product = dbContext.Products.Find(id);
            if (product != null)
                return Results.Ok(product.ToDto());
            else
                return Results.NotFound();
        });

        //POST
        group.MapPost("/", (CreateProductDto newProduct, InventoryContext dbContext) =>
        {
            Product product = newProduct.ToEntity();
            dbContext.Products.Add(product);
            dbContext.SaveChanges();
            return Results.Created();
        }).WithParameterValidation();

        //PUT /games
        group.MapPut("/{id}", (int id, UpdateProductDto updatedProduct, InventoryContext dbContext) =>
        {
            var existingProduct = dbContext.Products.Find(id);
            if (existingProduct is null)
                return Results.NotFound();

            existingProduct.Name = updatedProduct.Name;
            existingProduct.Price = updatedProduct.Price;
            existingProduct.Quantity = updatedProduct.Quantity;

            dbContext.SaveChanges();
            return Results.NoContent();
        });

        //DELETE
        group.MapDelete("/{id}", (int id, InventoryContext dbContext) =>
        {
            dbContext.Products.Where(product => product.Id == id).ExecuteDelete();
            return Results.NoContent();
        });

        return group;
    }
}