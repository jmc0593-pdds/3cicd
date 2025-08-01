using Microsoft.EntityFrameworkCore;
using InventoryApi.Entities;

namespace InventoryApi.Data;

public class InventoryContext(DbContextOptions<InventoryContext> options) : DbContext(options)
{
    public DbSet<Product> Products => Set<Product>();
}