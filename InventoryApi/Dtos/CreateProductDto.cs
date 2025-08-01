using System.ComponentModel.DataAnnotations;

namespace InventoryApi.Dtos;

public record class CreateProductDto(
    [Required][StringLength(50)] string Name,
    [Required][Range(0.01, 10_000)] decimal Price,
    int Quantity);