using InventoryApi.Data;
using InventoryApi.Endpoints;

var builder = WebApplication.CreateBuilder(args);
var connString = builder.Configuration.GetConnectionString("Inventory");
builder.Services.AddSqlite<InventoryContext>(connString);
var app = builder.Build();
app.MapProductEndpoints();
app.Run();
