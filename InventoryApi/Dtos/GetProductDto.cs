namespace InventoryApi.Dtos;

public record class GetProductDto(
    int Id,
    string Name,
    decimal Price,
    int Quantity);