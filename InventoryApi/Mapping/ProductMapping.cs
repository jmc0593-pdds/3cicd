using InventoryApi.Dtos;
using InventoryApi.Entities;

namespace InventoryApi.Mapping;

public static class ProductMapping
{
    public static Product ToEntity(this CreateProductDto product)
    {
        return new Product()
        {
            Name = product.Name,
            Price = product.Price,
            Quantity = product.Quantity
        };
    }

    public static GetProductDto ToDto(this Product product)
    {
        return new GetProductDto(
            product.Id,
            product.Name,
            product.Price,
            product.Quantity
        );
    }
}