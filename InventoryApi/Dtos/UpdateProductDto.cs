namespace InventoryApi.Dtos;

public record class UpdateProductDto(
    int Id,
    string Name,
    decimal Price,
    int Quantity);